using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{

    public int score = 0;
    Text scoreDisplay;
    
    // Start is called before the first frame update
    void Start()
    {
        scoreDisplay = GetComponent<Text>();
    }

    // Update is called once per frame

    public void updateScore(int scoreChange)
    {
        score += scoreChange;
        scoreDisplay.text = "Score: " + score.ToString();
    }
}
