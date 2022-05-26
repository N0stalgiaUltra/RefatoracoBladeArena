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
    
    public int placar1, placar2, pressBtn;
    
    public GameObject PauseMenu;
    public bool estaPausado;


    [Header("End Game Attributes")]
    [SerializeField] private GameObject victoryScreen;
    [SerializeField] private TextMeshProUGUI screenText;
    // Start is called before the first frame update
    void Start()
    {
        //1256x942
        //Screen.SetResolution(1024, 768, false);
        placar1 = 0;
        placar2 = 0;
        pressBtn = 0;
        Time.timeScale = 1;
        FindObjectOfType<AudioManager>().Play("MusicaFundo");
        estaPausado = pauseMenu.pausado;
    }

    // Update is called once per frame
    void Update()
    {
        //if(placar1 == 10 || placar2 == 10)

        if (placar1 >= 2)
        {
            GameVictory(1);
        }
        else if (placar2 >= 10)
        {
            GameVictory(2);
        }

        if (Input.GetKeyDown("escape"))
        {
            estaPausado = true;
            FindObjectOfType<AudioManager>().Play("AbreMenu");
            //FindObjectOfType<AudioManager>().Stop("MusicaFundo");
            PauseMenu.SetActive(true);
            //estaPausado = GetComponent<pauseMenu>().Pausar();   
            Time.timeScale = 0;
        }
    }

    private void GameStart() { }
    private void GameEnd() 
    {
        
        Time.timeScale = 0;
        
        placar1 = 0;
        placar2 = 0;
    }

    public void GameVictory(int player)
    {
        victoryScreen.SetActive(true);
        screenText.text = player == 1 ? "Player One Wins" : "Player 2 Wins";


        AudioManager.instance.VictorySound();

        GameEnd();
    }
}
