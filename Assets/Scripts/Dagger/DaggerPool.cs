using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaggerPool : MonoBehaviour
{
    [SerializeField] private DaggerFactory daggerFactory;

    [SerializeField] private int capacity;
    private Queue<Dagger> daggerQueue = new Queue<Dagger>();

    void Awake()
    {
        for (int i = 0; i < capacity; i++)
        {
            Dagger aux = daggerFactory.GetNewInstance();
            daggerQueue.Enqueue(aux);
        }
    }

    public void DaggerSpawn(Transform daggerSpawn)
    {
        if(daggerQueue.Count > 0)
        {
            Dagger aux = daggerQueue.Dequeue();
            aux.transform.position = daggerSpawn.position;
            aux.transform.rotation = daggerSpawn.rotation;
            aux.gameObject.SetActive(true);
        }
    }

    public void ReplenishQueue(Dagger inactiveDagger)
    {
        if (daggerQueue.Contains(inactiveDagger))
        {
            print("Este objeto já está na queue");
            return;
        }
        else
            daggerQueue.Enqueue(inactiveDagger);
    }
}
