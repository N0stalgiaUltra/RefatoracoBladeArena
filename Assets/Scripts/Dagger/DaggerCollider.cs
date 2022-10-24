using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaggerCollider : MonoBehaviour, ICollider
{
    private string colliderTag;
    public void GetHit()
    {
        if(colliderTag.Equals("Plataforma") || colliderTag.Equals("Plataforma2"))
            AudioManager.instance.PlatformHitSound();

        if (colliderTag.Equals("Player1"))
        {
            AudioManager.instance.ScoreSound();
            ScoreManager.instance.P2Score++;
        }

        if (colliderTag.Equals("Player2"))
        {
            AudioManager.instance.ScoreSound();
            ScoreManager.instance.P1Score++;
        }

        if (colliderTag.Equals("Adaga"))
            AudioManager.instance.DaggerHitSound();

        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {

        colliderTag = other.gameObject.tag;

        GetHit();
    }

    private void OnBecameInvisible()
    {

        Destroy(this.gameObject);
    }
}
