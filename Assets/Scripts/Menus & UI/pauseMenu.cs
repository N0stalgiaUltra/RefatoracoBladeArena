using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    private bool isPaused;
    [SerializeField] private GameObject pauseMenu;

    [Header("Buttons Reference")]
    [SerializeField] private Button returnButton;

    
    private void Start()
    { 
        returnButton.onClick.AddListener(() => CheckPause());

    }

    private void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            CheckPause();
        }
    }

    /// <summary>
    /// Controls the Pause Menu
    /// </summary>
    private void CheckPause()
    {
        if (!isPaused)
        {
            AudioManager.instance.OpenUISound();
            pauseMenu.SetActive(true);
            isPaused = true;
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
            pauseMenu.SetActive(false);
            isPaused = false;
        }
    }


}

