using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaggerCollider : MonoBehaviour, ICollider
{
    private ScoreManager scoreManager;
    private string colliderTag;

    private void Awake()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    public void GetHit()
    {
        if(colliderTag.Equals("Plataforma") || colliderTag.Equals("Plataforma2"))
            AudioManager.instance.PlatformHitSound();

        if (colliderTag.Equals("Player1"))
        {
            AudioManager.instance.ScoreSound();
            scoreManager.P2Score++;
        }

        if (colliderTag.Equals("Player2"))
        {
            AudioManager.instance.ScoreSound();
            scoreManager.P1Score++;
        }

        if (colliderTag.Equals("Dagger"))
            AudioManager.instance.DaggerHitSound();

        this.gameObject.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        colliderTag = other.gameObject.tag;
        GetHit();
    }

    private void OnBecameInvisible()
    {
        this.gameObject.SetActive(false);
    }
}
