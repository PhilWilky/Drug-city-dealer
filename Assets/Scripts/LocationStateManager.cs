using UnityEngine;

// This is our context file of our StateMachine

public class LocationStateManager : MonoBehaviour
{
    // Current state hold a reference to the ACTIVE state in the state manchine
    LocationBaseState currentState;

    public LocIndustrialState industrialState = new LocIndustrialState();
    public LocCentreState centreState = new LocCentreState();
    public LocPartRoadState partRoadState = new LocPartRoadState();
    public LocFerncliffeState ferncliffeState = new LocFerncliffeState();
    public LocLucyHallState lucyHallState = new LocLucyHallState();


    // Start is called before the first frame update
    void Start()
    {
        currentState = industrialState;

        currentState.EnterState(this);
    }

    // Update is called once per frame
    void Update()
    {
        currentState.UpdateState(this);
    }

    public void SwitchState(LocationBaseState state)
    {
        currentState = state;
        state.EnterState(this);
    }
}
