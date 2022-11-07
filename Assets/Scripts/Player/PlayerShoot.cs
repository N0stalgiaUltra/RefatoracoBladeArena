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
        this.playerType = typePlayer;
        if (this.playerType == TypePlayer.PLAYER2)
            spawnDagger.rotation = Quaternion.Euler(0, 180, 0);

        timer = 0f;
    }
    private void Start()
    {
        daggerPool = FindObjectOfType<DaggerPool>();
    }
    private void Update()
    {
        timer -= Time.deltaTime;
        if (InputShoot() && timer <= 0f)
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        daggerPool.DaggerSpawn(spawnDagger);
        timer = data.ShootRate;
    }

}
