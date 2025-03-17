using UnityEngine;

public class 사용예시 : FsmBase
{
    public static 사용예시 Instance { get; } = new 사용예시();

    public State state1 = new State();
    public State state2 = new State();
    public State state3 = new State();
    public State state4 = new State();
    public State state5 = new State();
    public State state6 = new State();

    사용예시() { }
}

public class Useing : MonoBehaviour // In Unity
{
    사용예시 ex = 사용예시.Instance;
    
    void Start()
    {
        ex.state1.OnEnter = () => OnState1Enter(); // OnEnter / state1
        ex.SetState(ex.state1); // change state
    }

    void OnState1Enter()
    {
        // code
    }
}