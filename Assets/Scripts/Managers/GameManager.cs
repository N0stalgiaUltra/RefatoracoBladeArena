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

    public int score1, score2;
    
    public GameObject PauseMenu;


    [Header("End Game Attributes")]
    [SerializeField] private GameObject victoryScreen;
    [SerializeField] private TextMeshProUGUI screenText;
    // Start is called before the first frame update
    void Start()
    {
        //1256x942
        //Screen.SetResolution(1024, 768, false);
        GameStart();
    }

    // Update is called once per frame
    void Update()
    {
        if (score1 >= 2)
        {
            GameVictory(1);
        }
        else if (score2 >= 10)
        {
            GameVictory(2);
        }

    }

    

    /// <summary>
    /// Called whenever a match starts
    /// </summary>
    private void GameStart() 
    {
        Time.timeScale = 1;
        score1 = score2 = 0;
        AudioManager.instance.BackgroundSound();
    }

    /// <summary>
    /// Called whenever a game ends
    /// </summary>
    public void GameEnd() 
    {
        Time.timeScale = score1 = score2 = 0;
    }

    /// <summary>
    /// Called whenever a player wins the match
    /// </summary>
    /// <param name="player">Type of player (ex: 1 stands for player 1)</param>
    public void GameVictory(int player)
    {
        victoryScreen.SetActive(true);
        screenText.text = player == 1 ? "Player One Wins" : "Player Two Wins";

        AudioManager.instance.VictorySound();

        GameEnd();
    }
    
}
