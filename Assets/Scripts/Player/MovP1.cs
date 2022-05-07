using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MovP1 : MonoBehaviour
{   
    
    public float velocidade = 4;
    bool estaChao, adagaHit;
    Rigidbody2D rb;
    
    public Animator animator;
    
    GameObject sensor;
    public bool r_chao;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        sensor = GameObject.Find("DetectorChao1");     
    }

  
    void FixedUpdate()
    {
        float p1x = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(p1x * velocidade, rb.velocity.y);
        animator.SetFloat("velocidadeAerea", rb.velocity.y);
        r_chao = sensor.GetComponent<ReconheceChao>().chao;


        if(p1x > 0)
        transform.eulerAngles = new Vector3(0,0,0);
        else if(p1x < 0)
        transform.eulerAngles = new Vector3(0,180,0);

        if(r_chao)
        {
            r_chao = true;
            animator.SetBool("estaChao", r_chao);
        }
        if(!r_chao) 
        {
            r_chao = false;
            animator.SetBool("estaChao", r_chao);
        }
        if(adagaHit == true)
        {
            animator.SetTrigger("Hurt");
            adagaHit = false;
        }

        else if(Input.GetButton("Jmp") && r_chao)
        {
            animator.SetTrigger("pulo");
            r_chao = false;
            animator.SetBool("estaChao", r_chao); 
            rb.velocity = new Vector2(rb.velocity.x, 7.5f);
        }
        else if(Mathf.Abs(p1x) > Mathf.Epsilon)
        {
            animator.SetInteger("estadoAnim", 1);
        }
        else
        animator.SetInteger("estadoAnim", 0);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Adaga")
        adagaHit = true;
    }

    void Andar()
    {
        FindObjectOfType<AudioManager>().Play("Passos");
    }
}
