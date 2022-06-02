using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour, ICollider
{
    [SerializeField] private Animator animator;

    public void GetHit()
    {
        print("Player colidiu com a adaga");
        animator.SetTrigger("Hurt");

    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Adaga"))
            GetHit();
    }
}

    
