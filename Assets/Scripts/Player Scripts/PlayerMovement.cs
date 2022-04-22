using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    PlayerControls playerControls;
    Animator animator;
    [Header("Equippable Locations")]
    public Transform swordLocation, gunLocation, batteryLocation, jetpackLocation;

    //Player Control Bools & Vectors
    private bool isMovePressed, isAimPressed, gunEquip, isFirePressed, isMeleePressed, isDodgeRollPressed, isSteamPressed;
    private Vector2 currentMoveInput, latestMoveInput, currentLookInput, currentGunAimInput;

    //Animator Bools
    int isWalkingHash, isAimingHash, gunEquipHash, isSteamDashingHash, dodgeRollHash, steamDashEnterHash, steamDashHash, steamDashExitHash;

    // Player states as enums
    public enum PlayerState { isAnimating, isRolling, isHurt, isDead, isAiming, isAttacking, isOnCover, isSneaking, isIdle, isFalling, isSteamDashing }

    public PlayerState currentState;

    public Rigidbody myBody;
    public Transform cam;
    public CapsuleCollider myCollider;

    private float colHeight;
    private float colRadius;

    public float playerSpeed = 300f;
    public float gravitySpeed = 10f;

    [SerializeField]
    private Vector3 direction, moveDir;
    public float movementMultiplier;
    private float targetAngle;
    private float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;

    public Vector3 aimDirection;
    public bool isAiming;
    private float camRayLength = 100f;
    private int floorMask;
    private Vector3 playerToMouse;

    public bool isGrounded;
    public Transform groundCheckPosition;
    public Transform rotCheckPosition;
    public LayerMask groundLayer;
    public Vector3 groundNormal;
    public Vector3 isGroundNormal;

    private LayerMask wallCoverLayer;
    public bool isOnWall;
    private Vector3 wallNormal;
    private Vector3 moveDirection;

    private Vector2 mousePos;
    public float maxShootDistance = 30f;
    private Vector3 aimDir;
    private Vector3 rayDir;
    public Transform aimNormalPosition;
    private float targetAimAngle;

    // Add in Dodge Roll
    public float dodgeRollTimer = 10f;
    public bool canRoll;
    private Vector3 dodgeRollDirection;
    // Add steam dash
    private float steamDashTimer = 10f;
    private float steamTimeCounter;
    private float steamInvincibility = 2f;
    private float steamTimeRecovery = 0.3f;
    private float baseSteamTimeRecovery;
    private float baseSteamInvincibility;
    public bool canSteamDash;
    private float steamReplen;
    private Vector3 steamDashDirection;
    private Vector3 lastSteamDashDirection;
    [SerializeField]
    private float steamTank;
    private float steamTankMax;
    private float steamTankMin;
    public bool steamDashEnded;
    // Add shooting
    // Add hurt
    public bool isInvincible;
    public float currentInvincibility;
    // Add death
    // Add score update
    // Add health
    // Add melee
    public bool canMelee;
    // Add cover system & movement

    // Start is called before the first frame update
    void Awake()
    {
        myBody = GetComponent<Rigidbody>();
        myCollider = GetComponent<CapsuleCollider>();
        colHeight = myCollider.height;
        colHeight = myCollider.radius;
        floorMask = LayerMask.GetMask("Ground");

        playerControls = new PlayerControls();
        animator = GetComponent<Animator>();

        isWalkingHash = Animator.StringToHash("isWalking");
        isAimingHash = Animator.StringToHash("isAiming");
        gunEquipHash = Animator.StringToHash("gunEquip");
        dodgeRollHash = Animator.StringToHash("DodgeRoll");
        isSteamDashingHash = Animator.StringToHash("isSteamDashing");
        steamDashEnterHash = Animator.StringToHash("SteamDashEnter");
        steamDashExitHash = Animator.StringToHash("SteamDashExit");
        steamDashHash = Animator.StringToHash("SteamDashing");

        playerControls.Player.Move.started += onMovementInput;
        playerControls.Player.Move.canceled += onMovementInput;
        playerControls.Player.Move.performed += onMovementInput;
        playerControls.Player.Look.started += onLookInput;
        //playerControls.Player.Look.canceled += onLookInput;
        playerControls.Player.Look.performed += onLookInput;
        playerControls.Player.GunAimDirection.started += onGunAimInput;
        playerControls.Player.GunAimDirection.canceled += onGunAimInput;
        playerControls.Player.GunAimDirection.performed += onGunAimInput;
        playerControls.Player.Fire.started += onFire;
        playerControls.Player.Fire.canceled += onFire;
        playerControls.Player.Aim.started += onAim;
        playerControls.Player.Aim.canceled += onAim;
        playerControls.Player.Melee.started += onMelee;
        playerControls.Player.Melee.canceled += onMelee;
        playerControls.Player.Roll.started += onDodgeRoll;
        playerControls.Player.Roll.canceled += onDodgeRoll;
        playerControls.Player.Steam.started += onSteam;
        playerControls.Player.Steam.canceled += onSteam;

        currentState = PlayerState.isIdle;
        isInvincible = false;
        canRoll = true;
        canSteamDash = true;

        steamTank = 30f;
        steamTankMax = 30f;
        steamTankMin = 10f;
        steamReplen = 0.5f;

        currentInvincibility = 0f;
    }

    void Start()
    {
        // storing default values
        baseSteamTimeRecovery = steamTimeRecovery;
        baseSteamInvincibility = steamInvincibility;
    }
    // Update is called once per frame
    void Update()
    {
        handleAnimation();
        HandleState();
        CheckGrounded();
        PlayerDirection();
        PlayerRotate();
        CalculateSteam();
        InvincibilityFrames(currentInvincibility);
    }
    private void FixedUpdate()
    {
        HandleVelocity();
    }

    void OnEnable()
    {
        playerControls.Player.Enable();
    }
    void OnDisable()
    {
        playerControls.Player.Disable();
    }
    void onMovementInput(InputAction.CallbackContext context)
    {
        if (context.started || context.performed) {
            latestMoveInput = context.ReadValue<Vector2>();
            direction = new Vector3(latestMoveInput.x, 0, latestMoveInput.y);
        }
        currentMoveInput = context.ReadValue<Vector2>();
        isMovePressed = currentMoveInput.x != 0 || currentMoveInput.y != 0;
    }
    void onLookInput(InputAction.CallbackContext context)
    {
        currentLookInput = context.ReadValue<Vector2>();
        mousePos = new Vector2(currentLookInput.x, currentLookInput.y);
        var screenCenter = new Vector2(Screen.width / 2, Screen.height / 2);
        aimDirection = screenCenter - mousePos;
        aimDirection.Normalize();
        PlayerAim(aimDirection);
    }
    void onAim(InputAction.CallbackContext context)
    {
        isAimPressed = context.ReadValueAsButton();
    }
    void onGunAimInput(InputAction.CallbackContext context)
    {
        currentGunAimInput = context.ReadValue<Vector2>();
        isAimPressed = currentGunAimInput.x != 0 || currentGunAimInput.y != 0;
        PlayerAim(-currentGunAimInput);
        
    }
    void onMelee(InputAction.CallbackContext context)
    {
        isMeleePressed = context.ReadValueAsButton();
    }
    void onFire(InputAction.CallbackContext context)
    {
        isFirePressed = context.ReadValueAsButton();
    }
    void onDodgeRoll(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            dodgeRollDirection = moveDirection;
        }
            isDodgeRollPressed = context.ReadValueAsButton();
    }
    void onSteam(InputAction.CallbackContext context)
    {
        isSteamPressed = context.ReadValueAsButton();
        if (context.canceled)
        {
            steamDashEnded = true;
            lastSteamDashDirection = moveDirection;
        }
    }
    void onSteamRelease(InputAction.CallbackContext context)
    {
        isSteamPressed = context.ReadValueAsButton();
    }
    void handleAnimation()
    {
        // get parameters from animator
        bool isWalking = animator.GetBool(isWalkingHash);
        bool isAiming = animator.GetBool(isAimingHash);
        bool isSteamDashing = animator.GetBool(isSteamDashingHash);

        if (isMovePressed && !isWalking)
        {
            animator.SetBool(isWalkingHash, true);
        } else if (!isMovePressed && isWalking)
        {
            animator.SetBool(isWalkingHash, false);
        }
        if (isAimPressed && !isAiming)
        {
            animator.Play(gunEquipHash);
            animator.SetBool(isAimingHash, true);
        }
        else if (!isAimPressed && isAiming)
        {
            animator.SetBool(isAimingHash, false);
        }
        if (isSteamPressed && !isSteamDashing)
        {
            animator.Play(steamDashEnterHash);
            animator.SetBool(isSteamDashingHash, true);
        }
        else if (!isSteamPressed && isSteamDashing)
        {
            animator.SetBool(isSteamDashingHash, false);
        }
    }
    void PlayerDirection()
    {
        if (direction.magnitude >= 0.1f) // will help for deadzones on joysticks
        {
            
            targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y; // gives the radians in degrees between where the player is facing and the direction we are moving
            moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;

            moveDirection = Vector3.ProjectOnPlane(moveDir, isGroundNormal).normalized;
            Debug.DrawRay(transform.position, moveDirection * maxShootDistance, Color.red);
        }
    }
    void UpdatePlayerState(PlayerState newstate)
    {
        if (newstate == currentState) { return; }
        PlayerState prevState = currentState;
        currentState = newstate;
    }
    void HandleState()
    {
        switch (currentState)
        {
            case PlayerState.isRolling:
                Debug.Log("Player Is Now Rolling");
                movementMultiplier = 1.5f;
                if (canRoll && currentState == PlayerState.isRolling) currentState = PlayerState.isIdle;
                break;
            case PlayerState.isSteamDashing:
                SteamDash();
                break;
            case PlayerState.isIdle:
                // go to dodgeroll state
                if (isDodgeRollPressed && canRoll) DodgeRoll();
                // go to steamdash state
                if (isSteamPressed && canSteamDash) SteamDash();
                // go to melee state
                if (isMeleePressed && canMelee) MeleeAttack();
                movementMultiplier = currentMoveInput.magnitude;
                break;
            default:
                currentState = PlayerState.isIdle;
                break;
        }
    }
    void HandleVelocity()
    {
        switch (currentState)
        {
            case PlayerState.isRolling:
                PlayerMove(dodgeRollDirection);
                break;
            case PlayerState.isSteamDashing:
                PlayerMove(steamDashDirection);
                break;
            case PlayerState.isIdle:
                // air control & fall
                if (!isGrounded) PlayerFall();
                // walk
                else if (isMovePressed && isGrounded) PlayerMove(moveDirection);
                // stand still
                else PlayerStandStill();
            break;
            default:
                break;
        }    
    }
    void CalculateSteam()
    {
        if (steamTank >= steamTankMax) {
            steamTank = steamTankMax;
            return; 
        }  
        else if (steamTank <= 0)
        {
            canSteamDash = false;
            steamTank = 0;
        }
        else if (steamTank > steamTankMin)
        {
            canSteamDash = true;
        }
        if (currentState != PlayerState.isSteamDashing) steamTank += steamReplen * Time.deltaTime;
    }
    void PlayerVelocity()
    {
        if (!isMovePressed && isGrounded)
        {
            myBody.velocity = Vector3.zero;
        }
        else if (!isGrounded)
        {
            myBody.velocity = new Vector3(moveDir.x * movementMultiplier * playerSpeed, -gravitySpeed, moveDir.z * movementMultiplier * playerSpeed) * Time.deltaTime;
        }
        else
        {
            myBody.velocity = moveDirection.normalized * movementMultiplier * playerSpeed * Time.deltaTime;
        }
    }
    void PlayerStandStill()
    {
        myBody.velocity = Vector3.zero;
    }
    void PlayerFall()
    {
        myBody.velocity = new Vector3(moveDir.x * movementMultiplier * playerSpeed, -gravitySpeed, moveDir.z * movementMultiplier * playerSpeed) * Time.deltaTime;
    }
    void PlayerMove(Vector3 playerMoveDirection)
    {
        myBody.velocity = playerMoveDirection.normalized * movementMultiplier * playerSpeed * Time.deltaTime;
    }
    void PlayerRotate()
    {
        // if player is aiming, rotate the player towards the aim point
        if (isAimPressed)
        {
            Quaternion newRotation = Quaternion.LookRotation(aimDir);
            // Set the player's rotation to this new rotation.
            myBody.MoveRotation(newRotation);
        }
        else
        {
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime); // great way to smooth rotations and angles in Unity
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
        }
        // otherwise rotate the player to the movement direction vector
    }
    void PlayerAim(Vector2 playerAimDirection)
    {
        targetAimAngle = Mathf.Atan2(-playerAimDirection.x, -playerAimDirection.y) * Mathf.Rad2Deg + cam.eulerAngles.y;
        aimDir = Quaternion.Euler(0f, targetAimAngle, 0f) * Vector3.forward;
        rayDir = Quaternion.Euler(aimNormalPosition.transform.rotation.x, aimNormalPosition.transform.rotation.y, aimNormalPosition.transform.rotation.z) * aimDirection;
        //Debug.DrawRay(transform.position, rayDir * maxShootDistance, Color.red);
        Debug.DrawRay(aimNormalPosition.transform.position, aimNormalPosition.transform.forward * maxShootDistance, Color.blue);
    }
    void PlayerAimRay()
    {
        // Create a ray from the mouse cursor on screen in the direction of the camera.
        Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        // Create a RaycastHit variable to store information about what was hit by the ray.
        RaycastHit floorHit;
        // Perform the raycast and if it hits something on the floor layer...
        if (Physics.Raycast(camRay, out floorHit, camRayLength, floorMask))
        {
            // Create a vector from the player to the point on the floor the raycast from the mouse hit.
            playerToMouse = floorHit.point - transform.position;

            // Ensure the vector is entirely along the floor plane.
            playerToMouse.y = 0f;
            Debug.DrawRay(transform.position, playerToMouse * maxShootDistance, Color.red);
        }
    }
    void CheckGrounded()
    {
        isGrounded = Physics.Raycast(groundCheckPosition.position, Vector3.down, 0.15f, groundLayer);
        if (!isGrounded)
        {
            isGroundNormal = Vector3.up;
            return;
        }
        RaycastHit hitNormalCheck;
        if (Physics.Raycast(groundCheckPosition.position, Vector3.down, out hitNormalCheck, 0.7f, groundLayer))
        {
            isGroundNormal = hitNormalCheck.normal;
            groundNormal = Vector3.Cross(Vector3.right, hitNormalCheck.normal).normalized;
            aimNormalPosition.transform.rotation = Quaternion.FromToRotation(aimNormalPosition.transform.up, hitNormalCheck.normal) * aimNormalPosition.transform.rotation; // FromToRotation stores a new quaternion using the hitnormalcheck as up, then we rotate that using our rotation
            rotCheckPosition.transform.rotation = Quaternion.FromToRotation(rotCheckPosition.transform.up, hitNormalCheck.normal) * rotCheckPosition.transform.rotation;
        }
        
    }
    void PlayerAimGun(Vector3 shootDirection)
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, shootDirection, maxShootDistance, groundLayer))
        {

        }
        Debug.DrawRay(transform.position, shootDirection * maxShootDistance, Color.red);
    }
    void DodgeRoll()
    {
        if (!canRoll) return;
        
        currentState = PlayerState.isRolling;
        animator.Play(dodgeRollHash);
        StartCoroutine(DodgeRollRoutine(dodgeRollTimer));
    }
    void SteamDash()
    {
        currentState = PlayerState.isSteamDashing;
        
        if (steamTank > 0 && !steamDashEnded)
        {
            steamInvincibility -= Time.deltaTime;
            currentInvincibility = steamInvincibility;
            steamTank -= Time.deltaTime;
            steamDashDirection = moveDirection;
            movementMultiplier = 4f;
        }
        else if (steamTank <= 0 || steamDashEnded)
        {
            canSteamDash = false;
            steamDashDirection = lastSteamDashDirection;
            steamTimeRecovery -= Time.deltaTime;
            movementMultiplier = 1f;
            if (currentState == PlayerState.isSteamDashing && steamTimeRecovery <= 0)
            {
                // reset the values once phase is completely ended
                steamDashEnded = false;
                currentState = PlayerState.isIdle;
                steamTimeRecovery = baseSteamTimeRecovery;
                steamInvincibility = baseSteamInvincibility;
                canSteamDash = true;
            }
        }
    }
    void MeleeAttack()
    {

    }
    void InvincibilityFrames(float newInvincibility)
    {
        if (newInvincibility <= 0) return;
        if (newInvincibility > currentInvincibility) currentInvincibility = newInvincibility;
        currentInvincibility -= Time.deltaTime;
        if (currentInvincibility > 0) isInvincible = true;
        else isInvincible = false;
    }
    private IEnumerator DodgeRollRoutine(float waitTime)
    {
        canRoll = false;
        yield return new WaitForSeconds(waitTime);
        if (currentState == PlayerState.isRolling) canRoll = true;
    }
}
