public abstract class PlayerBaseState
{
    protected PlayerStateMachine ctx;
    protected PlayerStateFactory factory;

    public PlayerBaseState(PlayerStateMachine currentContext, PlayerStateFactory playerStateFactory) {
        ctx = currentContext;
        factory = playerStateFactory;
    }

    public abstract void EnterState();
    public abstract void UpdateState();
    public abstract void ExitState();
    public abstract void CheckSwitchStates();
    public abstract void InitializeSubState();

    void UpdateStates()
    {

    }
    protected void SwitchState(PlayerBaseState newState)
    {
        // First exit the state
        ExitState();
        //then enter the new state
        newState.EnterState();
        ctx.CurrentState = newState;
    }
    protected void SetSuperState()
    {

    }
    protected void SetSubState()
    {

    }

}
