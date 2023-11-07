using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ScoreKeeper
{
    public static int score { get; private set; } = 0;

    public static void AddScore(int points)
    {
        score += points;
    }

    public static void ResetScore()
    {
        score = 0;
    }
}
