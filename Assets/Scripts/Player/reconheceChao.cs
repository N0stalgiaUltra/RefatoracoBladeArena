using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReconheceChao : MonoBehaviour
{
    public bool chao;

    void OnTriggerEnter2D ( Collider2D other)
    {
        if (other.CompareTag("Plataforma") || other.CompareTag("Plataforma2"))
            chao = true;
    }
    void OnTriggerExit2D ( Collider2D other)
    {
        if (other.CompareTag("Plataforma") || other.CompareTag("Plataforma2"))
            chao = false;
    }

}
