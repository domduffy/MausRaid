using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    PlayerControls playerControls;
    Animator animator;

    //Player Control Bools & Vectors
    private bool isMovePressed, isAimPressed, gunEquip, isFirePressed, isMeleePressed;
    private Vector2 currentMoveInput, currentLookInput, currentGunAimInput;

    int isWalkingHash, isAimingHash, gunEquipHash;

    public Rigidbody myBody;
    public Transform cam;
    public CapsuleCollider myCollider;

    private float colHeight;
    private float colRadius;

    public float playerSpeed = 300f;
    public float gravitySpeed = 10f;
    
    private Vector3 direction, moveDir;
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
    }

    // Update is called once per frame
    void Update()
    {
        handleAnimation();
        CheckGrounded();
        PlayerDirection();
        PlayerRotate();
    }
    private void FixedUpdate()
    {
        PlayerVelocity();
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
        currentMoveInput = context.ReadValue<Vector2>();
        direction = new Vector3(currentMoveInput.x, 0, currentMoveInput.y);
        isMovePressed = currentMoveInput.x != 0 || currentMoveInput.y != 0;
    }
    void onLookInput(InputAction.CallbackContext context)
    {
        currentLookInput = context.ReadValue<Vector2>();
        mousePos = new Vector2(currentLookInput.x, currentLookInput.y);
        var screenCenter = new Vector2(Screen.width / 2, Screen.height / 2);
        aimDirection = screenCenter - mousePos;
        aimDirection.Normalize();
        Debug.Log(aimDirection);
        PlayerAim(aimDirection);
    }
    void onAim(InputAction.CallbackContext context)
    {
        isAimPressed = context.ReadValueAsButton();
    }
    void onGunAimInput(InputAction.CallbackContext context)
    {
        currentGunAimInput = context.ReadValue<Vector2>();
        // aimDirection = new Vector3(currentGunAimInput.x, 0, currentGunAimInput.y);
        Debug.Log(currentGunAimInput);
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
    void handleAnimation()
    {
        // get parameters from animator
        bool isWalking = animator.GetBool(isWalkingHash);
        bool isAiming = animator.GetBool(isAimingHash);

        if (isMovePressed && !isWalking)
        {
            animator.SetBool(isWalkingHash, true);
        } else if (!isMovePressed && isWalking)
        {
            animator.SetBool(isWalkingHash, false);
        }
        if (isAimPressed && !isAiming)
        {
            animator.Play("GunEquip");
            animator.SetBool(isAimingHash, true);
        }
        else if (!isAimPressed && isAiming)
        {
            animator.SetBool(isAimingHash, false);
        }
    }
    void PlayerDirection()
    {
        if (direction.magnitude >= 0.1f) // will help for deadzones on joysticks
        {
            targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y; // gives the radians in degrees between where the player is facing and the direction we are moving
            moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;

            moveDirection = Vector3.ProjectOnPlane(moveDir, isGroundNormal);
            Debug.DrawRay(transform.position, moveDirection * maxShootDistance, Color.red);
        }
    }
    void PlayerVelocity()
    {
        if (direction.magnitude == 0 && isGrounded) {
            myBody.velocity = Vector3.zero;
        }
        else if (!isGrounded)
        {
            myBody.velocity = new Vector3(moveDir.x * direction.magnitude * playerSpeed, -gravitySpeed, moveDir.z * direction.magnitude * playerSpeed) * Time.deltaTime;
        }
        else
        {
            myBody.velocity = moveDirection.normalized * direction.magnitude * playerSpeed * Time.deltaTime;
        }
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
    void PlayerAimInput()
    {
        //mousePos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        var screenCenter = new Vector2(Screen.width/2, Screen.height/2);
        aimDirection = screenCenter - mousePos;
        aimDirection.Normalize();
    }
    void CheckGrounded()
    {
        isGrounded = Physics.Raycast(groundCheckPosition.position, Vector3.down, 0.15f, groundLayer);
        RaycastHit hitNormalCheck;
        if (Physics.Raycast(groundCheckPosition.position, Vector3.down, out hitNormalCheck, 0.7f, groundLayer))
        {
            isGroundNormal = hitNormalCheck.normal;
            groundNormal = Vector3.Cross(Vector3.right, hitNormalCheck.normal).normalized;
            aimNormalPosition.transform.rotation = Quaternion.FromToRotation(aimNormalPosition.transform.up, hitNormalCheck.normal) * aimNormalPosition.transform.rotation; // FromToRotation stores a new quaternion using the hitnormalcheck as up, then we rotate that using our rotation
            rotCheckPosition.transform.rotation = Quaternion.FromToRotation(rotCheckPosition.transform.up, hitNormalCheck.normal) * rotCheckPosition.transform.rotation;
        }
    }
    /* void HandleGravity()
    {
        if (isGrounded) {return;}
        // myBody.velocity = new Vector3(myBody.velocity.x, -gravitySpeed, myBody.velocity.z) * Time.deltaTime;
    } */
    void PlayerAimGun(Vector3 shootDirection)
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, shootDirection, maxShootDistance, groundLayer))
        {

        }
        Debug.DrawRay(transform.position, shootDirection * maxShootDistance, Color.red);
    }
}
