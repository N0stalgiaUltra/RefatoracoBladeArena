using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    #region TODO: Remove Singleton
    private static GameManager _instance;
    public static GameManager Instance => _instance;

    private void Awake() {
        if(_instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            _instance = this;
        }
    }
    #endregion

    [Header("End Game Attributes")]
    [SerializeField] protected TextMeshProUGUI screenText;
    [SerializeField] private VictoryScreen victoryScreen;
    
    
    [SerializeField] private PlayerFactory playerFactory;
    // Start is called before the first frame update

    [SerializeField] private GameObject player;
    private void Start()
    {
        GameStart(true);
    }

    private void Update()
    {

    }
    /// <summary>
    /// TODO: Redo the summary for the GameStartMethod
    /// </summary>
    public void GameStart(bool localMultiplayer) 
    {
        //if true -> instantiate both players and set input;
        //if false -> get multiplayer setting for input

        if (localMultiplayer)
        {
            for (int i = 0; i < 2; i++)
            {
                playerFactory.PlayerInputType = i;
                playerFactory.GetNewInstance();
            }

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
        
        victoryScreen.Setup();
        screenText.text = player == 1 ? "Player One Wins" : "Player Two Wins";

        GameEnd();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    
}
