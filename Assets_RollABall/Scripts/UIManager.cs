using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI  countText;
    public TextMeshProUGUI winText;

    public GameManager gameManager;

    public void Start(){
        winText.text = "";
    }

    public void updateText(){
        int currentScore = gameManager.getCurrentScore();
        countText.text = "Count : " + currentScore.ToString();
        if(currentScore >= gameManager.getScoreToWin()){
            winText.text = "You Win!";
        }
    }
}
