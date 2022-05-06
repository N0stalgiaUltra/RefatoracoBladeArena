using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adaga : MonoBehaviour
{
    
    Rigidbody2D rb;
    
    public float veloAdaga; 
    GameObject player, Player2, posAdaga, posAdaga2,direita, esquerda;
    
    void Awake()
    {
        //this.transform.rotation = new Vector3 (0,0,90);
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindWithTag("Player1");
        Player2 = GameObject.FindWithTag("Player2"); 
        posAdaga = GameObject.Find("posAdaga");
        posAdaga2 = GameObject.Find("posAdaga2");
        direita = GameObject.FindWithTag("LimiteDireita");
        esquerda = GameObject.FindWithTag("LimiteEsquerda");
        //inv = player.GetComponent<Movimento>().Inverso();
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {   
        rb.velocity = transform.right * veloAdaga;
    



        if(gameObject.transform.position.x > direita.transform.position.x)
        {
            gameObject.transform.position = new Vector2(esquerda.transform.position.x, gameObject.transform.position.y);
        }
        else if(gameObject.transform.position.x < esquerda.transform.position.x)
        {
            gameObject.transform.position = new Vector2(direita.transform.position.x, gameObject.transform.position.y);
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        
        if(other.gameObject.CompareTag("Player1"))
        {
            
            FindObjectOfType<AudioManager>().Play("AlteraPlacar");
            GameManager.Instance.placar2++;
            //player.GetComponent<PlayerManager>().hp-=10;
            Destroy(gameObject); 
            /*
            if(player.GetComponent<PlayerManager>().hp <= 0f)
            Destroy(player);
            */

        }
        
         if(other.gameObject.CompareTag("Player2"))
        {
            FindObjectOfType<AudioManager>().Play("AlteraPlacar");
            GameManager.Instance.placar1++;
            Destroy(gameObject); 

            /*
            if(player2.GetComponent<PlayerManager>().hp <= 0f)
            Destroy(player2);*/
        }
        if(other.gameObject.CompareTag("Adaga"))
        {
            Destroy(gameObject);
            FindObjectOfType<AudioManager>().Play("ColisaoAdaga");
        }
        
        if(other.gameObject.CompareTag("Plataforma"))
        {
            Destroy(gameObject);
            FindObjectOfType<AudioManager>().Play("ColisaoPlataforma");
        }
        if(other.gameObject.CompareTag("Plataforma2"))
        {
           Destroy(gameObject);
           FindObjectOfType<AudioManager>().Play("ColisaoPlataforma");
        }
    }
}
