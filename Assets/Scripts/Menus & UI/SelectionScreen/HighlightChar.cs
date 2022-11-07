using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightChar : MonoBehaviour
{
    [SerializeField] private SelectCharacterScreen selectCharacterScreen;
    [SerializeField] private RectTransform highlightP1;
    [SerializeField] private RectTransform highlightP2;

    [SerializeField] private bool selected;

    private void Start()
    {
        selected = true;
        HighlightState();
    }

    public void Enable(Vector2 cardTransform)
    {

        if (selectCharacterScreen.Count.Equals(2))
            highlightP1.anchoredPosition = cardTransform;

        else
        {
            highlightP2.anchoredPosition = cardTransform;
            selected = false;
        }

        HighlightState();
    }

    private void HighlightState()
    {
        highlightP1.gameObject.SetActive(selected);
        highlightP2.gameObject.SetActive(!selected);

    }
}
