using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerInput : PlayerType
{
    
    public bool InputShoot()
    {
        if (GetTypePlayer() == TypePlayer.PLAYER1)
            return Input.GetButtonDown("Fire1");
        else
            return Input.GetButtonDown("Fire2");

    }
    
    public float InputMove()
    {
        if (GetTypePlayer() == TypePlayer.PLAYER1)
            return Input.GetAxis("Horizontal");
        else
            return Input.GetAxis("Horizontal2");
    }
    
    public bool InputJump()
    {

        if (GetTypePlayer() == TypePlayer.PLAYER1)
            return Input.GetButton("Jmp");
        else
            return Input.GetButton("Jmp2");

    }
}

