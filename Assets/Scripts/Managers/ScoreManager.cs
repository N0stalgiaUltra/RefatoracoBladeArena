using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [Header ("Game Manager")]
    [SerializeField] private GameManager gameManager;

    [Header ("Score Attributes")]
    [SerializeField] private int p1Score, p2Score;
    [SerializeField] private int scoreToBeat; //can be in the config session


    [Header ("UI References")]
    [SerializeField] private TextMeshProUGUI p1ScoreText, p2ScoreText;


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
            End(1);
        }
        else if(p2Score >= scoreToBeat)
        {
            End(2);
        }
    }

    /// <summary>
    /// End the match when a player reaches the score to beat
    /// </summary>
    /// <param name="player"> player who won the match </param>
    private void End(int player)
    {
        gameManager.GameVictory(player);
        p1Score = p2Score = 0;
    }

    public int P1Score { get => this.p1Score; set => p1Score = value; }
    public int P2Score { get => this.p2Score; set => p2Score = value; }
}
