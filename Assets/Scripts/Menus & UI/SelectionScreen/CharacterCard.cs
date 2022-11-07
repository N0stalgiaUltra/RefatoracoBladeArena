using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterCard : MonoBehaviour
{
    [SerializeField] private CharacterData charData;
    [SerializeField] private Image mainSprite;

    [SerializeField] private Button thisButton;
    [SerializeField] private SelectCharacterScreen characterScreen;
    [SerializeField] private HighlightChar highlightChar;

    void Start()
    {
        mainSprite.sprite = charData.cardData.MainSprite.sprite;
        thisButton.onClick.AddListener(GetCharacter);
        
    }

    public void GetCharacter()
    {
        characterScreen.SetIndex(charData);
        highlightChar.Enable(this.gameObject.GetComponent<RectTransform>().anchoredPosition);
    }

}
