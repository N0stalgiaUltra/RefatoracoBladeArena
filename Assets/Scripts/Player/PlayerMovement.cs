using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : PlayerInput
{
    [Header("References")]
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Animator animator;
    [SerializeField] private ReconheceChao reconheceChao;

    [Header("Attributes")]
    [SerializeField] private float velocity;
    [SerializeField] private float jumpTimer = 1.5f;
    [SerializeField] private float jumpFactor;

    private bool adagaHit;
    // Update is called once per frame
    void FixedUpdate()
    {
        jumpTimer -= Time.fixedDeltaTime;
        Move();

        Jump(reconheceChao.chao);
        
    }
    
    private void Move()
    {
        print(InputMove().ToString());
        rb.velocity = new Vector2(InputMove() * velocity, rb.velocity.y);
        animator.SetFloat("velocidadeAerea", rb.velocity.y);
        
        if (Mathf.Abs(InputMove())> Mathf.Epsilon)
        {
            animator.SetInteger("estadoAnim", 1);
        }
        else
            animator.SetInteger("estadoAnim", 0);

        ChangeDirection(InputMove());
    }

    private void Jump(bool chao)
    {
        animator.SetBool("estaChao", chao);

        if(jumpTimer <= 0f)
        {
            if (InputJump() && chao)
            {
                animator.SetTrigger("pulo");
                rb.velocity = new Vector2(rb.velocity.x, jumpFactor);
                chao = false;
                animator.SetBool("estaChao", chao);
                jumpTimer = 1.5f;
            }
        }
    }
    private void ChangeDirection(float input)
    {
        if(this.playerType == PlayerType.PLAYER1)
        {
            if (input > 0)
                transform.eulerAngles = new Vector3(0, 0, 0);
            else if (input < 0)
                transform.eulerAngles = new Vector3(0, 180, 0);
        }
        else
        {
            if (input > 0)
                transform.eulerAngles = new Vector3(0, 180, 0);
            else if (input < 0)
                transform.eulerAngles = new Vector3(0, 0, 0);
        }
    }
    void RunSoundEvent()
    {
        AudioManager.instance.RunSound();    
    }

}
