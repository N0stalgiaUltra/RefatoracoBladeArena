using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSetup : PlayerType
{
    [SerializeField] private PlayerMovement playerMovement;
    [SerializeField] private PlayerShoot playerShoot;
    
    public void Initialize(int i)
    {
        SetType(i);
        print(this.playerType);
        playerShoot.Setup(this.playerType);
        playerMovement.Setup(this.playerType);

    }


}
