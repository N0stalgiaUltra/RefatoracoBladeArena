using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtState : BaseState
{
    private readonly Animator playerAnimator;
    private readonly Rigidbody2D playerRB;

    public HurtState(Animator animator, Rigidbody2D playerRB)
    {
        this.playerAnimator = animator;
        this.playerRB = playerRB;
    }

    public override void EnterState(PlayerStateManager manager)
    {
        playerRB.velocity = Vector2.zero;
    }

    public override void PhysicsUpdate(PlayerStateManager manager)
    {
    }

    public override void UpdateState(PlayerStateManager manager)
    {
        if (playerAnimator.GetCurrentAnimatorStateInfo(0).IsName("P1_hurt"))
            manager.SwitchState(manager.runState);
    }

}
