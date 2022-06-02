using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private int p1Score, p2Score;
    [SerializeField] private TextMeshProUGUI p1ScoreText, p2ScoreText;

    [SerializeField] private int scoreToBeat;

    public static ScoreManager instance;
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(instance);
        }
        else
            instance = this;
    }

    private void Start()
    {
        this.p1Score = p2Score = 0;
    }

    private void Update()
    {
        p1ScoreText.text = $"{p1Score}";
        p2ScoreText.text = $"{p2Score}";

        if(p1Score >= scoreToBeat)
        {
            GameManager.Instance.GameVictory(1);
        }
    }

    public int P1Score { get => this.p1Score; set => p1Score = value; }
    public int P2Score { get => this.p2Score; set => p2Score = value; }
}
