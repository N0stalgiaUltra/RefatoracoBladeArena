using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpState : BaseState
{
    private readonly PlayerMovement playerMovement;
    private readonly GroundCollider groundCollider;
    public JumpState(PlayerMovement playerMov, GroundCollider groundCol)
    {
        this.playerMovement = playerMov;
        this.groundCollider = groundCol;
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
        playerMovement.Jump(groundCollider.IsGrounded);
        Debug.Log($"isGrounded: {groundCollider.IsGrounded}");
        manager.SwitchState(manager.runState);
    }
}
