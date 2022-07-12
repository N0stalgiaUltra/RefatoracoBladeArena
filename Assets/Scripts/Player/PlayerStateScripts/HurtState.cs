using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtState : BaseState
{
    public override void EnterState(PlayerStateManager manager)
    {
        Debug.Log("Hurt");
    }

    public override void OnCollisionEnter(PlayerStateManager manager)
    {
        manager.playerCollider.GetHit();
    }

    public override void UpdateState(PlayerStateManager manager)
    {
        throw new System.NotImplementedException();
    }

}
