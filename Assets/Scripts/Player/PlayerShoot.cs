using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : PlayerInput
{
    [SerializeField] private Transform spawnDagger;
    [SerializeField] private CharacterData data;
    private DaggerPool daggerPool;
    
    
    private bool input;
    private float timer;
    private void Start()
    {
        daggerPool = FindObjectOfType<DaggerPool>();
        timer = 0f;
    }
    private void Update()
    {
        timer -= Time.deltaTime;
        input = InputShoot();

        if (input && timer <= 0f)
        {
            daggerPool.DaggerSpawn(spawnDagger);
            timer = data.shootRate;
        }
            

    }

}
