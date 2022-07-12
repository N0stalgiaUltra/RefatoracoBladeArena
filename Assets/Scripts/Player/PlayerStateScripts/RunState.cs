using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunState : BaseState
{
    public override void EnterState(PlayerStateManager manager)
    {
        Debug.Log("ENTREI NO ESTADO DE CORRER");
    }

    public override void OnCollisionEnter(PlayerStateManager manager)
    {
        throw new System.NotImplementedException();
    }

    public override void UpdateState(PlayerStateManager manager)
    {
        if (manager.playerMov.InputMove() == 0)
            manager.SwitchState(manager.idleState);
    }
}
