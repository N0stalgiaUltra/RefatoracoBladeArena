using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("UI Elements")]
    [SerializeField] protected TextMeshProUGUI screenText;

    [Header("Player Factory")]
    [SerializeField] private PlayerFactory playerFactory;

    [Header("Victory Screen")]
    [SerializeField] private GameObject victoryScreen;

    [Header("Multiplayer Data")]
    [SerializeField] private LocalMultiplayerData localMultiplayerData;

    private int numPlayers;
    private void Start()
    {
        numPlayers = PlayerPrefs.GetInt("PlayersNum");
        victoryScreen.SetActive(false);

        GameStart();

    }


    /// <summary>
    /// Method called to start game, instantiating the players and setting the time to run normally
    /// </summary>
    public void GameStart() 
    {
        
        for (int i = 0; i < numPlayers; i++)
        {
            //TODO: TRY CHANGE HARDCODED PART

            if (i == 0)
                playerFactory.PlayerIndex = localMultiplayerData.charIndexPlayerOne;
            else
                playerFactory.PlayerIndex = localMultiplayerData.charIndexPlayerTwo;

            playerFactory.PlayerInputType = i;
            playerFactory.GetNewInstance();
                
        }
        


        Time.timeScale = 1;
        AudioManager.instance.BackgroundSound();
    }

    /// <summary>
    /// Called whenever a game ends
    /// </summary>
    public virtual void GameEnd() 
    {
        Time.timeScale = 0;
    }

    /// <summary>
    /// Called whenever a player wins the match
    /// </summary>
    /// <param name="player">Type of player (ex: 1 stands for player 1)</param>
    public void GameVictory(int player)
    {
        AudioManager.instance.VictorySound();
        
        victoryScreen.SetActive(true);
        screenText.text = player == 1 ? "Player One Wins" : "Player Two Wins";

        GameEnd();
    }
    
}
