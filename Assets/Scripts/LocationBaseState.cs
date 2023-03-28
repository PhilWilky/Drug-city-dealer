using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This is our abstract file of our StateMachine

public abstract class LocationBaseState
{
    public abstract void EnterState(LocationStateManager loc);

    public abstract void UpdateState(LocationStateManager loc);

}
