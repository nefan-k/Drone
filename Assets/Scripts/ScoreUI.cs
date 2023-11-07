using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    private Text _scoreText;

    void Awake()
    {
        _scoreText = GetComponent<Text>();
    }

    
    void Update()
    {
        _scoreText.text = "Score: " + ScoreKeeper.score;
    }
}
