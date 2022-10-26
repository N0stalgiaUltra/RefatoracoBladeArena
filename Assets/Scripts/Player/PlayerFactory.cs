using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFactory : MonoBehaviour, IAbstractFactory<GameObject>
{
    [SerializeField] private GameObject[] playerPrefab;
    [SerializeField] private int playerIndex;
    [SerializeField] private int playerInputType;

    public int PlayerInputType {
        set {
            playerInputType = (value.Equals(0) || value.Equals(1)) ? value : 0;
        }   
    }

    public GameObject GetNewInstance()
    {
        //  TODO : REMIND TO CHANGE THE ARRAY INDEX
        var aux = Instantiate(playerPrefab[playerInputType], transform);
        aux.GetComponent<PlayerType>().SetType(playerInputType);
        return aux;
    }


}
