using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunState : BaseState
{

    private readonly PlayerMovement player;
    private readonly GroundCollider grounded;

    public RunState(PlayerMovement player, GroundCollider grounded)
    {
        this.player = player;
        this.grounded = grounded;
    }

    public override void EnterState(PlayerStateManager manager)
    {
    }


    public override void UpdateState(PlayerStateManager manager)
    {
        if (manager.InputJump())
            manager.SwitchState(manager.jumpState);
    }


    public override void PhysicsUpdate(PlayerStateManager manager)
    {        
        player.Move(grounded.IsGrounded);
    }



}
