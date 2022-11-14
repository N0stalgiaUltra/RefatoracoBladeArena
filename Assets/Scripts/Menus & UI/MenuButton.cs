using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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

    private void BackMenu()
    {
        AudioManager.instance.ClickButtonSound();
        SceneManager.LoadScene(0);
    }

    protected void OpenClose(bool active)
    {
        AudioManager.instance.ClickButtonSound();

        if (active)
            objectControlled.SetActive(false);
        else
            objectControlled.SetActive(true);
    }

    private void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    private void Quit()
    {
        Application.Quit();
    }


}
