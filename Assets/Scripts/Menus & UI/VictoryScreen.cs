using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VictoryScreen : MonoBehaviour
{
    [SerializeField] private Button restartMatch, backToMenu;
    

    public void Setup()
    {
        transform.GetChild(0).gameObject.SetActive(true);
        restartMatch.onClick.AddListener(() => Load(true));
        backToMenu.onClick.AddListener(() => Load(false));
    }

    private void Load(bool restart)
    {
        AudioManager.instance.ClickButtonSound();

        if (restart)
            SceneManager.LoadScene("Game");
        else
            SceneManager.LoadScene("Menu");

        transform.GetChild(0).gameObject.SetActive(false);

    }
}
