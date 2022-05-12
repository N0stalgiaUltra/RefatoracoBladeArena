using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaggerCollider : MonoBehaviour, ICollider
{
    private string colliderTag;
    public void GetHit()
    {
        if(colliderTag.Equals("Plataforma") || colliderTag.Equals("Plataforma2"))
        {
            //print($"Adaga colidiu com {colliderTag}");   
            //FindObjectOfType<AudioManager>().Play("ColisaoPlataforma");
        }

        if (colliderTag.Equals("Player1"))
        {
            //print("Adaga colidiu com Player 1");
            //FindObjectOfType<AudioManager>().Play("AlteraPlacar");
            //GameManager.Instance.placar2++;

        }

        if (colliderTag.Equals("Player2"))
        {
            //FindObjectOfType<AudioManager>().Play("AlteraPlacar");
            //GameManager.Instance.placar1++;

            //print("Adaga colidiu com Player2");
        }

        if (colliderTag.Equals("Adaga"))
        {
            //print("Adaga colidiu com Adaga");
            //FindObjectOfType<AudioManager>().Play("ColisaoAdaga");
        }

        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.CompareTag("Player1"))
            colliderTag = "Player1";

        if (other.gameObject.CompareTag("Player2"))
            colliderTag = "Player2";

        if (other.gameObject.CompareTag("Adaga"))
            colliderTag = "Adaga";

        if (other.gameObject.CompareTag("Plataforma"))
            colliderTag = "Plataforma";

        if (other.gameObject.CompareTag("Plataforma2"))
            colliderTag = "Plataforma2";

        GetHit();
    }
}
