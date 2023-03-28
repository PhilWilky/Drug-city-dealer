using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This is one of our Concrete State

public class LocPartRoadState : LocationBaseState
{
    private string locationName = "Park Road";

    public override void EnterState(LocationStateManager loc)
    {
        Debug.Log("You are in the '" + locationName + "'");
    }

    public override void UpdateState(LocationStateManager loc)
    {

    }
}
