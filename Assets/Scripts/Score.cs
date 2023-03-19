using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public static int currScore;

    TextMeshProUGUI currScoreText;

    void Start()
    {
        currScoreText = GetComponent<TextMeshProUGUI>();
        PlayerPrefs.SetInt("Score", currScore);
        currScoreText.text = "Score: " + PlayerPrefs.GetInt("Score");
    }

    void Update()
    {
        currScoreText.text = "Score: " + currScore;
    }
}
