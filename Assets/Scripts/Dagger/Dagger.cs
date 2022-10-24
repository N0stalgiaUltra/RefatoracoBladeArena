using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dagger : MonoBehaviour
{
    
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private DaggerData daggerData;


    void Start()
    {
        rb.velocity = transform.right * daggerData.velocity;

    }
    


}
