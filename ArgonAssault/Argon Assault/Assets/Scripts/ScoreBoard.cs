using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBoard : MonoBehaviour
{
    private int score = 0;

    public void UpdateScore(int deltaScore)
    {
        score += deltaScore;
        Debug.Log(score);
    }
}
