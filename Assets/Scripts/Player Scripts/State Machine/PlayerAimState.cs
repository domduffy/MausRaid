using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAimState : PlayerBaseState
{
    private float targetAimAngle;
    private Vector3 rayDir;

    public PlayerAimState(PlayerStateMachine currentContext, PlayerStateFactory playerStateFactory) : base(currentContext, playerStateFactory) { }
    public override void EnterState()
    {
        // PlayerAim(aimDirection);
    }
    public override void UpdateState()
    {
    }
    public override void ExitState()
    {
    }
    public override void InitializeSubState()
    {
    }
    public override void CheckSwitchStates()
    {
    }
    void PlayerAim(Vector2 playerAimDirection)
    {
        // Fix by following Youtube state machine vid from 20:43

        /* targetAimAngle = Mathf.Atan2(-playerAimDirection.x, -playerAimDirection.y) * Mathf.Rad2Deg + cam.eulerAngles.y;
        aimDir = Quaternion.Euler(0f, targetAimAngle, 0f) * Vector3.forward;
        rayDir = Quaternion.Euler(aimNormalPosition.transform.rotation.x, aimNormalPosition.transform.rotation.y, aimNormalPosition.transform.rotation.z) * aimDirection;
        //Debug.DrawRay(transform.position, rayDir * maxShootDistance, Color.red);
        Debug.DrawRay(aimNormalPosition.transform.position, aimNormalPosition.transform.forward * maxShootDistance, Color.blue); */
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
