using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaggerFactory : MonoBehaviour, IAbstractFactory<Dagger>
{
    [SerializeField] private Dagger daggerPrefab;
    public Dagger GetNewInstance()
    {
        Dagger aux = Instantiate(daggerPrefab, this.transform);
        aux.gameObject.SetActive(false);
        return aux;
    }

}
