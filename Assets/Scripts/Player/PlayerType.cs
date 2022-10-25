using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerType : MonoBehaviour
{
    public enum TypePlayer { PLAYER1, PLAYER2 };

    private TypePlayer playerType;

    public void SetType(int id)
    {
        switch (id)
        {
            case 0: playerType = TypePlayer.PLAYER1;
                break;
            case 1: playerType = TypePlayer.PLAYER2;
                break;
        }
    }
    
    public TypePlayer GetTypePlayer()
    {
        return playerType;
    }
}
