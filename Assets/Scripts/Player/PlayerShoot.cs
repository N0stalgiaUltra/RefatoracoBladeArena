using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : PlayerInput
{
    [SerializeField] private GameObject dagger;
    [SerializeField] private Transform spawnDagger;

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
            Shoot();
            timer = 1.5f;
        }
            

    }

    public void Shoot()
    {
        GameObject aux = Instantiate(dagger, spawnDagger.position, spawnDagger.rotation);
        //toca som
        Destroy(aux, 3.75f);
    }

}
