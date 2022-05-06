using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reconheceChao : MonoBehaviour
{
    public bool chao;



    void OnTriggerEnter2D ( Collider2D other)
    {
        if(other.gameObject.tag == "Plataforma")
        {
            chao = true;
        }    
        
        if(other.gameObject.tag == "Plataforma2")
        {
            chao = true;
        }    
    }
      void OnTriggerExit2D ( Collider2D other)
    {
        if(other.gameObject.tag == "Plataforma")
        {
            chao = false;
        } 
        if(other.gameObject.tag == "Plataforma2")
        {
            chao = false;
        }       
    }
}
