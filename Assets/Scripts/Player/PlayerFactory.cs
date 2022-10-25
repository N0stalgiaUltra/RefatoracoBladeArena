using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFactory : MonoBehaviour, IAbstractFactory<GameObject>
{
    [SerializeField] private GameObject[] playerPrefab;
    [SerializeField] private int playerIndex;
    public GameObject GetNewInstance()
    {
        //PlayerPrefs.GetInt("PlayerIndex", 0);
        //  TODO : REMIND TO REMOVE RANDOM.RANGE
        var aux = Instantiate(playerPrefab[playerIndex], transform);
        aux.GetComponent<PlayerType>().SetType(playerIndex);
        return aux;
    }


}
