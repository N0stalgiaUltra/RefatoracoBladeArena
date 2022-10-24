using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : PlayerInput
{
    [SerializeField] private Transform spawnDagger;
    [SerializeField] private DaggerPool daggerPool;
    private bool input;

    [SerializeField] private float timer = 1.5f;
    private void Start()
    {
        timer = 0f;
    }
    private void Update()
    {
        timer -= Time.deltaTime;
        input = InputShoot();

        if (input && timer <= 0f)
        {
            daggerPool.DaggerSpawn(spawnDagger);
            timer = 1.5f;
        }
            

    }

    //public void Shoot()
    //{
    //    GameObject aux = Instantiate(dagger, spawnDagger.position, spawnDagger.rotation);
    //    //toca som
    //    Destroy(aux, 3.75f);
    //}

}
