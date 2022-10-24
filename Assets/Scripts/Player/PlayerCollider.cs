using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour, ICollider
{
    [SerializeField] private Animator animator;

    private string colliderTag;
    public void GetHit()
    {
        if(colliderTag.Equals("Dagger"))
            animator.SetTrigger("Hurt");

    }
    void OnCollisionEnter2D(Collision2D other)
    {
        colliderTag = other.gameObject.tag;
        GetHit();
    }
}

    
