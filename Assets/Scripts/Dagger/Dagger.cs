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
    private void OnEnable()
    {
        AddVelocity();
    }
    private void OnDisable()
    {
        rb.velocity = Vector2.zero;
        daggerPool.ReplenishQueue(this);
    }

    private void AddVelocity() => rb.velocity = transform.right * daggerData.velocity;

}
