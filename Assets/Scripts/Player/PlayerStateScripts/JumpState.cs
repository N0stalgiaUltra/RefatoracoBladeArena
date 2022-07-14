using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpState : BaseState
{
    PlayerMovement playerMovement;
    
    public JumpState(PlayerMovement playerMovement)
    {
        this.playerMovement = playerMovement;
    }

    public override void EnterState(PlayerStateManager manager)
    {
        Debug.Log("JumpState");
        //Debug.Log($"isGrounded: {manager.groundCollider.chao}");

    }

    public override void UpdateState(PlayerStateManager manager)
    {

    }


    public override void PhysicsUpdate(PlayerStateManager manager)
    {
        playerMovement.Jump(manager.groundCollider.chao);
        Debug.Log($"isGrounded: {manager.groundCollider.chao}");
        manager.SwitchState(manager.runState);
    }
}
