using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFactory : MonoBehaviour, IAbstractFactory<GameObject>
{
    [SerializeField] private GameObject playerPrefab;
    public GameObject GetNewInstance()
    {
        GameObject aux = Instantiate(playerPrefab, transform);
        
        return aux;
    }
}
