using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuButton : MonoBehaviour
{
    public enum ButtonType { OPENCLOSE, START, QUIT}
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
            case ButtonType.QUIT:
                button.onClick.AddListener(this.Quit);
                break;
            default:
                Debug.LogError("Defina um tipo de botão");
                break;
        }
    }

    protected void OpenClose(bool active)
    {
        print("click");
        AudioManager.instance.ClickButtonSound();

        if (active)
            objectControlled.SetActive(false);
        else
            objectControlled.SetActive(true);
    }

    private void StartGame()
    {
        SceneManager.LoadScene("Game");
    }
    private void Quit()
    {
        print("sai do jogos");
        Application.Quit();
    }


}
