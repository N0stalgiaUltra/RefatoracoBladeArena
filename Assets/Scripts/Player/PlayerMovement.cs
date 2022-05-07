using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : PlayerInput
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float velocidade;
    [SerializeField] private Animator anim;

    [SerializeField] private ReconheceChao reconheceChao;

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
        Jump(reconheceChao.chao);
        ChangeDirection(InputMove());
        

    }
    
    private void Move()
    {
        rb.velocity = new Vector2(InputMove() * velocidade, rb.velocity.y);
    }

    private void Jump(bool chao)
    {
        if(InputJump() && chao)
        {
            rb.velocity = new Vector2(rb.velocity.x, 7.5f);
        }
    }
    private void ChangeDirection(float input)
    {
        if (input > 0)
            transform.eulerAngles = new Vector3(0, 0, 0);
        else if (input < 0)
            transform.eulerAngles = new Vector3(0, 180, 0);
    }


}
