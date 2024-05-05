using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public int scoreToWin;
    private int count;

    public UnityEvent onScoreChange;

    public void IncrementScore()
    {
        count++;
        onScoreChange.Invoke();
    }

    void Start()
    {
        count = 0;
        onScoreChange.Invoke();
    }

    public int getScoreToWin(){
        return scoreToWin;
    }

    public int getCurrentScore(){
        return count;
    }
}
