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

    public int PlayerIndex
    {
        set => this.playerIndex = value;
    }

    public GameObject GetNewInstance()
    {
        print(playerIndex);
        // Change the input type inside the character prefab
        var setup = playerPrefab[playerIndex].GetComponent<PlayerSetup>();
        setup.Initialize(playerInputType);
        
        //instantiate prefab with player type already settled.
        var aux = Instantiate(playerPrefab[playerIndex], playerSpawn[playerInputType].position, Quaternion.identity);
        return aux;
    }



}
