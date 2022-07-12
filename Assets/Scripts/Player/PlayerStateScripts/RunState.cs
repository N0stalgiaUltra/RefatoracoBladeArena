using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunState : BaseState
{
    Rigidbody2D rb;
    Animator animator;
    public override void EnterState(PlayerStateManager manager)
    {
        rb = manager.GetComponent<Rigidbody2D>();
        animator = manager.animator;
        Debug.Log("RunState");
    }


    public override void UpdateState(PlayerStateManager manager)
    {
        Move(manager.playerInput, manager);
    }

    private void Move(PlayerInput input, PlayerStateManager manager)
    {
        rb.velocity = new Vector2(input.InputMove() * 4, rb.velocity.y); 
        //animator.SetFloat("velocidadeAerea", rb.velocity.y); 

        if (Mathf.Abs(input.InputMove()) > Mathf.Epsilon)
        {
            animator.SetInteger("estadoAnim", 1);
        }
        else
        {
            animator.SetInteger("estadoAnim", 0);
            manager.SwitchState(manager.idleState);
        }

        //ChangeDirection(InputMove());
    }

    //private void ChangeDirection(float input)
    //{

    //    if (this.playerType == PlayerType.PLAYER1)
    //    {
    //        if (input > 0)
    //            transform.eulerAngles = new Vector3(0, 0, 0);
    //        else if (input < 0)
    //            transform.eulerAngles = new Vector3(0, 180, 0);
    //    }
    //    else
    //    {
    //        if (input > 0)
    //            transform.eulerAngles = new Vector3(0, 180, 0);
    //        else if (input < 0)
    //            transform.eulerAngles = new Vector3(0, 0, 0);
    //    }
    //}
}
