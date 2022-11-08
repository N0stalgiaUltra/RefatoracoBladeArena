using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSetup : PlayerType
{
    [SerializeField] private PlayerMovement playerMovement;
    [SerializeField] private PlayerShoot playerShoot;
    [SerializeField] private SpriteRenderer spriteRenderer;
    public void Initialize(int i)
    {
        SetType(i);
        playerShoot.Setup(this.playerType);
        playerMovement.Setup(this.playerType);

        if (this.playerType == TypePlayer.PLAYER2)
        {
            spriteRenderer.flipX = false;
            this.gameObject.tag = "Player2";
        }
    }


}
