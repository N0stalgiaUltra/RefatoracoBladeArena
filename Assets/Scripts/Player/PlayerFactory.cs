using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerFactory : MonoBehaviour, IAbstractFactory<GameObject>
{
    [SerializeField] private GameObject[] playerPrefab = new GameObject[3];
    [SerializeField] private Transform[] playerSpawn = new Transform[2];
    [SerializeField] private int playerIndex;
    [SerializeField] private int playerInputType;

    public int PlayerInputType
    {
        set
        {
            playerInputType = (value.Equals(0) || value.Equals(1)) ? value : 0;
        }
    }

    public GameObject GetNewInstance()
    {
        // Change the input type inside the character prefab
        var setup = playerPrefab[playerInputType].GetComponent<PlayerSetup>();
        setup.Initialize(playerInputType);
        
        //instantiate prefab with player type already settled.
        var aux = Instantiate(playerPrefab[playerInputType], playerSpawn[playerInputType].position, Quaternion.identity);
        return aux;
    }



}
