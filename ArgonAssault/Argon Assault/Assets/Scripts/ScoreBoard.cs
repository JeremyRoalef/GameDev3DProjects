using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreBoard : MonoBehaviour
{
    TextMeshProUGUI scoreText;

    private int score = 0;

    private void Awake()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        scoreText.text = "0";
    }

    public void UpdateScore(int deltaScore)
    {
        score += deltaScore;
        Debug.Log(score);
        scoreText.text = score.ToString();

    }
}
