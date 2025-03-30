public class FsmBase
{
    public delegate void StateAction();

    public class State
    {
        public StateAction OnEnter;
        public StateAction OnExit;
        public StateAction OnUpdate; 

        public void Enter() => OnEnter?.Invoke();
        public void Exit() => OnExit?.Invoke();
        public void Update() => OnUpdate?.Invoke();
    }

    protected State _currentState;

    public void SetState(State newState)
    {
        _currentState?.Exit();
        _currentState = newState;
        _currentState.Enter();
    }

    public void Update() => _currentState?.Update(); // In Unity(Update func)
}