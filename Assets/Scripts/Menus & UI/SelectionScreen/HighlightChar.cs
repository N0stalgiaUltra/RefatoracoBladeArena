using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightChar : MonoBehaviour
{
    [SerializeField] private SelectCharacterScreen selectCharacterScreen;
    [SerializeField] private RectTransform highlightP1;
    [SerializeField] private RectTransform highlightP2;


    private void Update()
    {
        if (selectCharacterScreen.Count.Equals(2))
            HighlightState(true);
        else
            HighlightState(false);


    }
    //se ele fica sem trocar, ele n muda
    public void Enable(Vector2 cardTransform)
    { 
        highlightP1.anchoredPosition = cardTransform;
        highlightP2.anchoredPosition = cardTransform;
    }

    private void HighlightState(bool value)
    {
        highlightP1.gameObject.SetActive(value);
        highlightP2.gameObject.SetActive(!value);

    }
}
