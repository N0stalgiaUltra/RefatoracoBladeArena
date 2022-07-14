using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : BaseState
{



    public override void EnterState(PlayerStateManager manager)
    {
        
        Debug.Log("Idle");
    }

    public override void PhysicsUpdate(PlayerStateManager manager)
    {

    }

    public override void UpdateState(PlayerStateManager manager)
    {
 
    }
}
