using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GenSingleton : GenericSingleton<GenSingleton>
{
    //public Text textUI;
    public TMP_Text tmptextUI;
    public int playerScore = 0;
    public int playerScoreMax = 100;
    public Slider mainSlider;

    public void AddScore(int amount) 
    { 
        playerScore += amount; 
        tmptextUI.text = playerScore.ToString();
        mainSlider.value = (float)playerScore / (float)playerScoreMax;
    }

    public void SubmitSliderValue()
    {

        tmptextUI.text = mainSlider.value.ToString();
    }

    void Start()
    {
        tmptextUI.text = "22222222";
    }
}
