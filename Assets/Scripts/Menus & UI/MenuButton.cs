using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/// <summary>
/// Controls the buttons behaviour 
/// </summary>
public class MenuButton : MonoBehaviour
{
    public enum ButtonType { OPENCLOSE, START, QUIT, MENU}
    public ButtonType buttonType;

    [SerializeField] private Button button;
    [SerializeField] private GameObject objectControlled;
    private void Start()
    {
        switch (this.buttonType)
        {
            case ButtonType.OPENCLOSE:
                button.onClick.AddListener(() => OpenClose(objectControlled.activeInHierarchy));
                break;
            case ButtonType.START:
                button.onClick.AddListener(this.StartGame);
                break;
            case ButtonType.MENU:
                button.onClick.AddListener(this.BackMenu);
                break;
            case ButtonType.QUIT:
                button.onClick.AddListener(this.Quit);
                break;
            default:
                Debug.LogError("Defina um tipo de botão");
                break;
        }
    }

    /// <summary>
    /// Open or Close an active object in scene
    /// </summary>
    /// <param name="active"> value of the object state in the scene</param>
    private void OpenClose(bool active)
    {
        AudioManager.instance.ClickButtonSound();

        if (active)
            objectControlled.SetActive(false);
        else
            objectControlled.SetActive(true);
    }

    /// <summary>
    /// Return to menu
    /// </summary>
    private void BackMenu()
    {
        AudioManager.instance.ClickButtonSound();
        SceneManager.LoadScene(0);
    }

    /// <summary>
    /// Start the game
    /// </summary>
    private void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    /// <summary>
    /// Quit the game
    /// </summary>
    private void Quit()
    {
        Application.Quit();
    }


}
