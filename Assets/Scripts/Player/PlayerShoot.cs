using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : PlayerInput
{
    [SerializeField] private Transform spawnDagger;
    [SerializeField] private CharacterData data;

    private DaggerPool daggerPool;
    private float timer;

    public void Setup(TypePlayer typePlayer)
    {
        print(typePlayer);
        this.playerType = typePlayer;
        daggerPool = FindObjectOfType<DaggerPool>();
        timer = 0f;
    }
    private void Update()
    {
        timer -= Time.deltaTime;
        if (InputShoot() && timer <= 0f)
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        print("Shoot");
        //daggerPool.DaggerSpawn(spawnDagger);
        //timer = data.shootRate;
    }

}
