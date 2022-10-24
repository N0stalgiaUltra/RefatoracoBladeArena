using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : PlayerInput
{
    [SerializeField] private Transform spawnDagger;
    [SerializeField] private DaggerPool daggerPool;
    [SerializeField] private PlayerData data;
    
    private bool input;
    private float timer;
    private void Start()
    {
        timer = data.shootRate;
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
