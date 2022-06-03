using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dagger : MonoBehaviour
{
    
    [SerializeField] Rigidbody2D rb;
    public float veloAdaga;
    [SerializeField] GameObject player, Player2, limitesContainer;
    [SerializeField] private Transform direita, esquerda;

    void Awake()
    {
        //this.transform.rotation = new Vector3 (0,0,90);
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        direita = GameObject.FindGameObjectWithTag("LimiteDireita").GetComponent<Transform>();
        esquerda = GameObject.FindGameObjectWithTag("LimiteEsquerda").GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {   
        rb.velocity = transform.right * veloAdaga;

        if (gameObject.transform.position.x > direita.transform.position.x)
        {
            gameObject.transform.position = new Vector2(esquerda.transform.position.x, gameObject.transform.position.y);
        }
        else if (gameObject.transform.position.x < esquerda.transform.position.x)
        {
            gameObject.transform.position = new Vector2(direita.transform.position.x, gameObject.transform.position.y);

        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        
        //if(other.gameObject.CompareTag("Player1"))
        //{
            
        //    //FindObjectOfType<AudioManager>().Play("AlteraPlacar");
        //    //GameManager.Instance.placar2++;
        //    //Destroy(gameObject);

        //    //player.GetComponent<PlayerManager>().hp-=10;
        //    /*
        //    if(player.GetComponent<PlayerManager>().hp <= 0f)
        //    Destroy(player);
        //    */

        //}

        //if (other.gameObject.CompareTag("Player2"))
        //{
        //    //FindObjectOfType<AudioManager>().Play("AlteraPlacar");
        //    //GameManager.Instance.placar1++;
        //    //Destroy(gameObject); 

        //    /*
        //    if(player2.GetComponent<PlayerManager>().hp <= 0f)
        //    Destroy(player2);*/
        //}
        //if(other.gameObject.CompareTag("Adaga"))
        //{
        //    Destroy(gameObject);
        //    FindObjectOfType<AudioManager>().Play("ColisaoAdaga");
        //}
        
        //if(other.gameObject.CompareTag("Plataforma"))
        //{
        //    Destroy(gameObject);
        //    FindObjectOfType<AudioManager>().Play("ColisaoPlataforma");
        //}
        //if(other.gameObject.CompareTag("Plataforma2"))
        //{
        //   Destroy(gameObject);
        //   FindObjectOfType<AudioManager>().Play("ColisaoPlataforma");
        //}
    }
    private void OnBecameInvisible()
    {
       
        Destroy(this.gameObject);
    }
}
