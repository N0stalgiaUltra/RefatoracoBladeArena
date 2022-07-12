using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtState : BaseState
{
    Animator animator;
    public override void EnterState(PlayerStateManager manager)
    {
        animator = manager.GetComponent<Animator>();
        animator.SetTrigger("Hurt");
    }


    public override void UpdateState(PlayerStateManager manager)
    {
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("P1_hurt"))
            manager.SwitchState(manager.idleState);
    }

}
