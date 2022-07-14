using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunState : BaseState
{

    protected PlayerMovement player;
    private GroundCollider grounded;

    public RunState(PlayerMovement player, GroundCollider grounded)
    {
        this.player = player;
        this.grounded = grounded;
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
        player.Move(grounded.chao);
    }



}
