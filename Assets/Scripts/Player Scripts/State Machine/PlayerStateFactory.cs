public class PlayerStateFactory
{
    PlayerStateMachine context;

    public PlayerStateFactory(PlayerStateMachine currentContext)
    {
        context = currentContext;
    }

    public PlayerBaseState Idle() {
        return new PlayerIdleState(context, this);
    }
    public PlayerBaseState Aim() {
        return new PlayerAimState(context, this);
    }
    public PlayerBaseState Walk() {
        return new PlayerWalkState(context, this);
    }
    public PlayerBaseState Fall() {
        return new PlayerFallState(context, this);
    }
    public PlayerBaseState Grounded() {
        return new PlayerGroundedState(context, this);
    }
}
