using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtState : BaseState
{
    Animator animator;
    Rigidbody2D playerRB;

    public HurtState(Animator animator, Rigidbody2D playerRB)
    {
        this.animator = animator;
        this.playerRB = playerRB;
    }

    public override void EnterState(PlayerStateManager manager)
    {
        Debug.Log("HurtState");
        playerRB.velocity = Vector2.zero;
    }

    public override void PhysicsUpdate(PlayerStateManager manager)
    {
        throw new System.NotImplementedException();
    }

    public override void UpdateState(PlayerStateManager manager)
    {
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("P1_hurt"))
            manager.SwitchState(manager.runState);
    }

}
