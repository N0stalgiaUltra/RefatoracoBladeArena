using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : BaseState
{
    public override void EnterState(PlayerStateManager manager)
    {
        Debug.Log("entra no estado");
    }

    public override void OnCollisionEnter(PlayerStateManager manager)
    {
        throw new System.NotImplementedException();
    }

    public override void UpdateState(PlayerStateManager manager)
    {
        if (manager.playerMov.InputMove() > 0)
            manager.SwitchState(manager.runState);
            
    }
}
