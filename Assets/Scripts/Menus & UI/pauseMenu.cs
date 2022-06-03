using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    private bool estaPausado;
    [SerializeField] private GameObject menuConfig, pauseMenu;

    [Header("Buttons Reference")]
    [SerializeField] private Button continueButton, configButton;
    [SerializeField] private Button returnConfigButton, returnMenuButton;

    
    private void Start()
    { 
        continueButton.onClick.AddListener(() => ContinueGame());
        configButton.onClick.AddListener(() => ConfigMenu(false));
        returnConfigButton.onClick.AddListener(() => ConfigMenu(true));
        returnMenuButton.onClick.AddListener(() => ReturnToMenu());
    }

    private void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            OpenPause();
        }
    }

    /// <summary>
    /// Controls the Pause Menu
    /// </summary>
    private void OpenPause()
    {
        if (!estaPausado)
        {
            AudioManager.instance.OpenUISound();
            pauseMenu.SetActive(true);
            estaPausado = true;
            Time.timeScale = 0;
        }
        else
        {
            ContinueGame();
        }
    }

    private void ContinueGame()
    {
        if (estaPausado)
        {
            Time.timeScale = 1;
            pauseMenu.SetActive(false);
            estaPausado = false;
        }
        else return;
    }
    
    private void ConfigMenu(bool open)
    {
        if (!open)
        {
            pauseMenu.SetActive(!open);
            menuConfig.SetActive(open);
            AudioManager.instance.ClickButtonSound();
        }
        else
        {
            pauseMenu.SetActive(open);
            menuConfig.SetActive(!open);
            AudioManager.instance.ClickButtonSound();
        }
    }

    private void ReturnToMenu()
    {
        AudioManager.instance.ClickButtonSound();
        SceneManager.LoadScene("Menu");
    }

}

