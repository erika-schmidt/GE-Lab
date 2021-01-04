﻿using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private float score = 0.0f;

    private int difficultyLevel = 1;
    private int maxDifficultyLevel = 10;
    private int scoreToNextLevel = 10;

    private bool isDead = false;

    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead)
            return;

        if (score >= scoreToNextLevel)
            LevelUp();

        score += Time.deltaTime * difficultyLevel;
        score++;
        scoreText.text = ((int)score).ToString();
    }

    void LevelUp()
    {
        if (difficultyLevel == maxDifficultyLevel)
            return;

        scoreToNextLevel *= 2;
        difficultyLevel++;

    }

    public void OnDeath()
    {
        isDead = true;
    }
}
