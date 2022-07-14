using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunState : BaseState
{

    protected PlayerMovement player;

    public RunState(PlayerMovement player)
    {
        this.player = player;
    }

    public override void EnterState(PlayerStateManager manager)
    {
        Debug.Log("RunState");
    }


    public override void UpdateState(PlayerStateManager manager)
    {
        if (manager.InputJump())
            manager.SwitchState(manager.jumpState);
    }


    public override void PhysicsUpdate(PlayerStateManager manager)
    {        
        player.Move();
    }



}
