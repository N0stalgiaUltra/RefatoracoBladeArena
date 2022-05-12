using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private int p1Score, p2Score;

    public delegate void PlayerScore(int diff);
    public static event PlayerScore PlayerScored;

    private void Start()
    {
        p1Score = p2Score = 0;
        //P1Score += AddScore(1);
        //P2Score += AddScore(3);
        PlayerScored(5);
    }

    private void Score()
    {

    }
    //public int AddScore(int score)
    //{
    //    return score;
    //}

    public int P1Score { get => p1Score; set => p1Score = value; }
    public int P2Score { get => p2Score; set => p2Score = value; }
}
