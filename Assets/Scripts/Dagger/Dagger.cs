using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dagger : MonoBehaviour
{
    
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private DaggerData daggerData;

    private DaggerPool daggerPool;

    private void Awake()
    {
        daggerPool = FindObjectOfType<DaggerPool>();

    }
    void Start()
    {
        rb.velocity = transform.right * daggerData.velocity;

    }

    private void OnDisable()
    {
        daggerPool.ReplenishQueue(this);
    }


}
