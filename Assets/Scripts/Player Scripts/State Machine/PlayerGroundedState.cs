﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGroundedState : PlayerBaseState
{
    public PlayerGroundedState(PlayerStateMachine currentContext, PlayerStateFactory playerStateFactory) : base(currentContext, playerStateFactory) { }
    public override void EnterState()
    {
        Debug.Log("Grounded Now");
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
        if (ctx.IsAimPressed)
        {
            SwitchState(factory.Aim());
        }
    }
}
