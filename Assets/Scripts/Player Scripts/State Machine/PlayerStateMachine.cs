using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerStateMachine : MonoBehaviour
{
    PlayerControls playerControls;
    Animator animator;
    [Header("Equippable Locations")]
    public Transform swordLocation, gunLocation, batteryLocation, jetpackLocation;

    //Player Control Bools & Vectors
    private bool isMovePressed, isAimPressed, gunEquip, isFirePressed, isMeleePressed;
    private Vector2 currentMoveInput, currentLookInput, currentGunAimInput;

    // Set State Machine
    PlayerBaseState currentState;
    PlayerStateFactory states;

    // getters & setters
    public PlayerBaseState CurrentState { get { return currentState; } set { currentState = value; } }

    // Getters & Setters
    public bool IsAimPressed { get { return isAimPressed; } }
    public bool IsMovePressed { get { return isMovePressed; } }
    public bool GunEquip { get { return gunEquip; } }
    public bool IsFirePressed { get { return isFirePressed; } }
    public bool IsMeleePressed { get { return isMeleePressed; } }
    public Animator Animator { get { return animator; } }
    public Vector2 CurrentMoveInput { get { return currentMoveInput; } }
    public Vector2 CurrentLookInput { get { return currentLookInput; } }
    public Vector2 CurrentAimInput { get { return currentGunAimInput; } }


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

    public Transform aimNormalPosition;
    

    void Awake()
    {
        myBody = GetComponent<Rigidbody>();
        myCollider = GetComponent<CapsuleCollider>();
        colHeight = myCollider.height;
        colHeight = myCollider.radius;
        floorMask = LayerMask.GetMask("Ground");

        playerControls = new PlayerControls();
        animator = GetComponent<Animator>();

        states = new PlayerStateFactory(this);
        currentState = states.Grounded();
        currentState.EnterState();

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
    void Update()
    {
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
        //Debug.Log(aimDirection);
        //PlayerAim(aimDirection);
    }
    void onAim(InputAction.CallbackContext context)
    {
        isAimPressed = context.ReadValueAsButton();
    }
    void onGunAimInput(InputAction.CallbackContext context)
    {
        currentGunAimInput = context.ReadValue<Vector2>();
        // aimDirection = new Vector3(currentGunAimInput.x, 0, currentGunAimInput.y);
        //Debug.Log(currentGunAimInput);
        isAimPressed = currentGunAimInput.x != 0 || currentGunAimInput.y != 0;
        //PlayerAim(-currentGunAimInput);

    }
    void onMelee(InputAction.CallbackContext context)
    {
        isMeleePressed = context.ReadValueAsButton();
    }
    void onFire(InputAction.CallbackContext context)
    {
        isFirePressed = context.ReadValueAsButton();
    }

    void PlayerVelocity()
    {
        if (direction.magnitude == 0 && isGrounded)
        {
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
}
