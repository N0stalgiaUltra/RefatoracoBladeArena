using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public enum PlayerType { PLAYER1, PLAYER2};

    public PlayerType playerType;
    
    public bool InputShoot()
    {
        if (this.playerType == PlayerType.PLAYER1)
            return Input.GetButtonDown("Fire1");
        else
            return Input.GetButtonDown("Fire2");

    }
    
    public bool InputMove()
    {
        return true;
    }
    
    public bool InputJump()
    {
        return true;
    }
}

