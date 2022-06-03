using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerInput : MonoBehaviour
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
    
    public float InputMove()
    {
        if (this.playerType == PlayerType.PLAYER1)
            return Input.GetAxis("Horizontal");
        else
            return Input.GetAxis("Horizontal2");
    }
    
    public bool InputJump()
    {
        if (this.playerType == PlayerType.PLAYER1)
            return Input.GetButton("Jmp");
        else
            return Input.GetButton("Jmp2");
    }
}

