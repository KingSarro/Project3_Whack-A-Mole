using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour{
    //Made a reference to TMP_Text
    [SerializeField] TMP_Text scoreText;
    //
    private int score = 0;


    // Start is called before the first frame update
    void Start(){
        //Changes the text of scoreText
        scoreText.text = "Score: " + score.ToString();
    }//Closes the start method

    //This method is to change the current score//
    public void AddScore(int scoreToAdd){
        //adds whatever the value of scoreToAdd to score
        score += scoreToAdd;
        //Changes the text of scoreText
        scoreText.text = "Score: " + score.ToString();
    }//Closes the addScore method
}
