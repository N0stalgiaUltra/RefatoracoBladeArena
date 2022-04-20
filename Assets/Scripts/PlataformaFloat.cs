using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaFloat : MonoBehaviour
{
    public float amplitude = 0.15f;
    public float frequency = 0.7f;

    public Vector2 diffPosicao;
    public Vector2 tempPos;

    void Start()
    {
        diffPosicao = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(this.gameObject.tag == "Plataforma2")
        {
            tempPos = diffPosicao;
            tempPos.y = Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;

            transform.position = tempPos;
        }
        
        if(this.gameObject.tag == "Plataforma3")
        {
             tempPos = diffPosicao;
         tempPos.x = Mathf.Cos(Time.fixedTime * Mathf.PI * frequency) * amplitude;

         transform.position = tempPos;
        }
         
        
    }
}
