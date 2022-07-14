using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : PlayerInput
{
    [Header("References")]
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Animator animator;
    [SerializeField] private GroundCollider groundCollider;

    [Header("Attributes")]
    [SerializeField] private PlayerData playerData;
    [SerializeField] private float jumpTimer;

    // Update is called once per frame
    private void Start() => jumpTimer = playerData.jumpTimer;

    void FixedUpdate() => jumpTimer -= Time.fixedDeltaTime;

    public void Move(bool isGrounded)
    {
        animator.SetBool("estaChao", isGrounded);
        rb.velocity = new Vector2(InputMove() * playerData.velocity, rb.velocity.y);
        
        if (Mathf.Abs(InputMove())> Mathf.Epsilon)
        {
            animator.SetInteger("estadoAnim", 1);
        }
        else
            animator.SetInteger("estadoAnim", 0);

        ChangeDirection(InputMove());
    }


    public void Jump(bool isGrounded)
    {
        animator.SetBool("estaChao", isGrounded);
        if (jumpTimer <= 0f)
        {
            if (InputJump() && isGrounded)
            {
                animator.SetTrigger("pulo");
                rb.velocity = new Vector2(rb.velocity.x, playerData.jumpFactor);
                isGrounded = false;
                animator.SetBool("estaChao", isGrounded);
                jumpTimer = playerData.jumpTimer;
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
    void RunSoundEvent() => AudioManager.instance.RunSound();    

}
