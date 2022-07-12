using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtState : BaseState
{
    public override void EnterState(PlayerStateManager manager)
    {
        manager.animator.SetTrigger("Hurt");
    }


    public override void UpdateState(PlayerStateManager manager)
    {
        if (manager.animator.GetCurrentAnimatorStateInfo(0).IsName("P1_hurt"))
            manager.SwitchState(manager.idleState);
    }

}
