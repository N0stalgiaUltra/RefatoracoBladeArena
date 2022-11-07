using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectCharacterScreen : MonoBehaviour
{
    [SerializeField] private int characterIndex;

    [SerializeField] private Button confirmButton;

    //como diferir quando temos multi e singleplayer? 
    [SerializeField] private bool localMultiplayer;
    [SerializeField] private int count;

    private void Start()
    {
        confirmButton.onClick.AddListener(ConfirmAction); 
    }

    public void SetIndex(CharacterData data)
    {
        this.characterIndex = data.CharIndex;
        
    }

    private void ConfirmAction()
    {
        if (count < 2)
        {
            count++;

            if (localMultiplayer)
            {
                print("Selected character: " + characterIndex);
                print(count);
                //entra no single
            }
            else
            {
                print("Selected character: " + characterIndex);
                //entra no lobby/partida
            }
        }
        else
            confirmButton.interactable = false;


    }

}
