using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody myBody;
    public Transform cam;
    public CapsuleCollider myCollider;
    private float colHeight;
    private float colRadius;

    public float playerSpeed = 300f;
    private float horizontal;
    private float vertical;
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
    }

    // Update is called once per frame
    void Update()
    {

        PlayerInput();
        PlayerAimInput();
        PlayerAim();
        //PlayerAimRay();
        CheckGrounded();

        //PlayerAimGun(aimDirection);

        if (direction.magnitude >= 0.1f) // will help for deadzones on joysticks
        {
            targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y; // gives the radians in degrees between where the player is facing and the direction we are moving
            
            moveDir = Quaternion.Euler(0f, targetAngle,0f) * Vector3.forward;


            Quaternion playerMoveRot = Quaternion.LookRotation(moveDir, isGroundNormal);
            // Vector3 slopeDirection = Vector3.up - groundNormal * Vector3.Dot(Vector3.up, groundNormal);
            // moveDirection = playerMoveRot * moveDir;
            moveDirection = Vector3.ProjectOnPlane(moveDir, isGroundNormal);
            Debug.DrawRay(transform.position, moveDirection * maxShootDistance, Color.red);



        }
        
        PlayerRotate();
        
    }
    private void FixedUpdate()
    {
        if (direction.magnitude == 0 && isGrounded) { myBody.velocity = Vector3.zero; }
        

        //myBody.velocity = moveDir.normalized * direction.magnitude * playerSpeed * Time.deltaTime;

        //myBody.velocity = moveDirection.normalized * direction.magnitude * playerSpeed * Time.deltaTime;

        Vector3 temp = Vector3.Cross(groundNormal, direction);
        Vector3 myDirection = Vector3.Cross(groundNormal, temp);
        

        myBody.velocity = moveDirection.normalized * direction.magnitude * playerSpeed * Time.deltaTime;

        // myBody.velocity = Vector3.Cross(Vector3.Cross(groundNormal, transform.TransformDirection(new Vector3(direction.x, 0, direction.z))), groundNormal).normalized * direction.magnitude * playerSpeed * Time.deltaTime;


    }

    void PlayerRotate()
    {
        // if player is aiming, rotate the player towards the aim point
        if (isAiming)
        {
            // Create a quaternion (rotation) based on looking down the vector from the player to the mouse.
            // var playerAimVector = new Vector3(-aimDirection.x, 0, -aimDirection.y);
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
    void PlayerInput()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        direction = new Vector3(horizontal, 0, vertical).normalized;  
    }
    void PlayerAim()
    {
        targetAimAngle = Mathf.Atan2(-aimDirection.x, -aimDirection.y) * Mathf.Rad2Deg + cam.eulerAngles.y;
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
        mousePos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        var screenCenter = new Vector2(Screen.width/2, Screen.height/2);
        aimDirection = screenCenter - mousePos;
        aimDirection.Normalize();
    }
    void CheckGrounded()
    {
        isGrounded = Physics.Raycast(groundCheckPosition.position, Vector3.down, 0.1f, groundLayer);
        RaycastHit hitNormalCheck;
        if (Physics.Raycast(groundCheckPosition.position, Vector3.down, out hitNormalCheck, 0.7f, groundLayer))
        {
            isGroundNormal = hitNormalCheck.normal;
            groundNormal = Vector3.Cross(Vector3.right, hitNormalCheck.normal).normalized;
            aimNormalPosition.transform.rotation = Quaternion.FromToRotation(aimNormalPosition.transform.up, hitNormalCheck.normal) * aimNormalPosition.transform.rotation; // FromToRotation stores a new quaternion using the hitnormalcheck as up, then we rotate that using our rotation
            rotCheckPosition.transform.rotation = Quaternion.FromToRotation(rotCheckPosition.transform.up, hitNormalCheck.normal) * rotCheckPosition.transform.rotation;
        }
    }
/*    velocity = Vector3.Cross(Vector3.Cross(hitInfo.normal, transform.TransformDirection(Vector3(inputDirection.x, 0, inputDirection.y)), hitInfo.normal).normalized* targetSpeed;*/
    void PlayerAimGun(Vector3 shootDirection)
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, shootDirection, maxShootDistance, groundLayer))
        {

        }
        Debug.DrawRay(transform.position, shootDirection * maxShootDistance, Color.red);
    }
}
