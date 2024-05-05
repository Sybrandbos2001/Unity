using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI winText;
    public TextMeshProUGUI loseText;

    public PlayerInput playerInput;

    public void Start(){
        winText.text = "";
        loseText.text = "";

    }

    public void updateWinnersText(){
        winText.text = "Gevonden!";        
    }

    public void updateLosersText(){
        winText.text = "Gore dief!";
        playerInput.canMove = false;        
    }
}
