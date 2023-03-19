using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HighScore : MonoBehaviour
{
    public static int highScore = 0;

    TextMeshProUGUI highScoreText;

    void Start()
    {
        highScoreText = GetComponent<TextMeshProUGUI>();

        if (Score.currScore > highScore)
        {
            highScore = Score.currScore;
        }
        PlayerPrefs.SetInt("Highscore", highScore);
        highScoreText.text = "Highscore: " + PlayerPrefs.GetInt("Highscore");
    }
}
