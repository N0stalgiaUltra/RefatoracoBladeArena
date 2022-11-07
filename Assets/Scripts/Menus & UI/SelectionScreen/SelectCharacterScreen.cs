using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectCharacterScreen : MonoBehaviour
{
    [SerializeField] private int characterIndex;

    [SerializeField] private Button confirmButton;

    [SerializeField] private LocalMultiplayerData localMultiplayerData;
    //como diferir quando temos multi e singleplayer? 
    [SerializeField] private bool localMultiplayer;
    [SerializeField] private int count;
    public int countagain;
    private void Start()
    {
        //TODO: REMOVE
        

        count = localMultiplayer ? 2 : 1;

        PlayerPrefs.SetInt("PlayersNum", count);
        PlayerPrefs.Save();

        confirmButton.onClick.AddListener(ConfirmAction); 
    }

    public void SetIndex(CharacterData data)
    {
        this.characterIndex = data.cardData.CharIndex;
        
    }
    private void Update()
    {
        if(count == 0)
            SceneManager.LoadScene(2);

    }
    private void ConfirmAction()
    {
        if (count > 0)
        {
            SetCharIndex(count);
            count--;
        }
        else
        {
            confirmButton.interactable = false;
        }

    }

    private void SetCharIndex(int count)
    {
        if (count == 2)
            localMultiplayerData.charIndexPlayerOne = characterIndex;

        else if (count == 1)
            localMultiplayerData.charIndexPlayerTwo = characterIndex;

        else
            return;
    }

    public int Count { get => count; }
}
