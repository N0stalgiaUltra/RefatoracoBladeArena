using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class LimitesTeleport : MonoBehaviour
{
    
    // Start is called before the first frame update
    
    public GameObject limDir, limEsq;
    public Transform p1, p2, direita, esquerda, baixo, cima;
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
       
        if(p1.position.x > direita.position.x)
        {
            p1.position = new Vector2(esquerda.position.x, p1.position.y);
        }
        else if(p1.position.x < esquerda.position.x)
        {
            p1.position = new Vector2(direita.position.x, p1.position.y);
        }

        if(p2.position.x > direita.position.x)
        {
            p2.position = new Vector2(esquerda.position.x, p2.position.y);
        }
        else if(p2.position.x < esquerda.position.x)
        {
            p2.position = new Vector2(direita.position.x, p2.position.y);
        }
        
        /*
        if(p1.position.y < baixo.position.y)
        {
            p1.position = new Vector2(p1.position.x, cima.position.y);
        }*/
    }


}
