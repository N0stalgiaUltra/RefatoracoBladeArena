using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunState : BaseState
{
    Rigidbody2D rb;
    Animator animator;
    Transform playerTransform;

    public RunState(Rigidbody2D rb, Animator animator, Transform playerTransform)
    {
        this.rb = rb;
        this.animator = animator;
        this.playerTransform = playerTransform;
    }

    public override void EnterState(PlayerStateManager manager)
    {
        Debug.Log("RunState");
    }


    public override void UpdateState(PlayerStateManager manager)
    {
        Move(manager);
    }

    private void Move(PlayerStateManager manager)
    {
        rb.velocity = new Vector2(manager.InputMove() * 4, rb.velocity.y); 
        //animator.SetFloat("velocidadeAerea", rb.velocity.y); 

        if (Mathf.Abs(manager.InputMove()) > Mathf.Epsilon)
        {
            animator.SetInteger("estadoAnim", 1);
        }
        else
        {
            animator.SetInteger("estadoAnim", 0);
            manager.SwitchState(manager.idleState);
        }

        ChangeDirection(manager);
    }

    private void ChangeDirection(PlayerStateManager manager)
    {

        if (manager.playerType == PlayerInput.PlayerType.PLAYER1)
        {
            if (manager.InputMove() > 0)
                playerTransform.eulerAngles = new Vector3(0, 0, 0);
            else if (manager.InputMove() < 0)
                playerTransform.eulerAngles = new Vector3(0, 180, 0);
        }
        else
        {
            if (manager.InputMove() > 0)
                playerTransform.eulerAngles = new Vector3(0, 180, 0);
            else if (manager.InputMove() < 0)
                playerTransform.eulerAngles = new Vector3(0, 0, 0);
        }
    }
}
