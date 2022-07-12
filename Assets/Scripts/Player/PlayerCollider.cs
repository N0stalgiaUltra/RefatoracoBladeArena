using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour, ICollider
{
    [SerializeField] private Animator animator;
    //public PlayerStateManager stateManager;

    private void Update()
    {
        //if (Input.anyKeyDown)
        //    GetHit();
    }
    public void GetHit()
    {
        print("Player colidiu com a adaga");
        animator.SetTrigger("Hurt");
        //stateManager.SwitchState(stateManager.hurtState);

    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Adaga"))
            GetHit();
    }
}

    
