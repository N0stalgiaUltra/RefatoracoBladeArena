using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private bool estaPausado;
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
        if (!estaPausado)
        {
            AudioManager.instance.OpenUISound();
            pauseMenu.SetActive(true);
            estaPausado = true;
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
            pauseMenu.SetActive(false);
            estaPausado = false;
        }
    }


}

