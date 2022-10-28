using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunState : BaseState
{

    private readonly PlayerMovement playerMovement;
    private readonly GroundCollider groundedCollider;
    private readonly PlayerShoot playerShoot;

    public RunState(PlayerMovement playerMov, GroundCollider groundedCol, PlayerShoot shoot)
    {
        this.playerMovement = playerMov;
        this.groundedCollider = groundedCol;
        this.playerShoot = shoot;
    }

    public override void EnterState(PlayerStateManager manager)
    {
    }


    public override void UpdateState(PlayerStateManager manager)
    {
        //if (playerShoot.InputShoot())
        //    playerShoot.Shoot();

        if (playerMovement.InputJump())
            manager.SwitchState(manager.jumpState);
    }


    public override void PhysicsUpdate(PlayerStateManager manager)
    {        
        playerMovement.Move(groundedCollider.IsGrounded);
    }



}
