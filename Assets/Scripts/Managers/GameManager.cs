using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    #region Singleton
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
    // Start is called before the first frame update
    void Start()
    {
        GameStart();
    }

    /// <summary>
    /// Called whenever a match starts
    /// </summary>
    private void GameStart() 
    {
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
        victoryScreen.Setup();
        screenText.text = player == 1 ? "Player One Wins" : "Player Two Wins";

        AudioManager.instance.VictorySound();

        GameEnd();
    }
    
}
