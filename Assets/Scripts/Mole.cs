using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Mole : MonoBehaviour{
    //Makes a reference to the score manager script
    [SerializeField] ScoreManager scoreManager;

    //Vars used to keep track of how long the mole has been spawned
    private float secsTillDespawn = 10f;//60fps
    private float timerCount = 0f;

    //This update is used to count the seconds of how long this mole is around
    void FixedUpdate(){
        //Adds a second to timerCount
        timerCount += Time.deltaTime;

        //Checks if the timer reaches the secTillDespawn. 
        //If they do...
        if(timerCount >= secsTillDespawn){
            //Destroy this game object
            Destroy(gameObject);
            //Resets the counter
            timerCount = 0f;
        }//closes timer check
    }//closes fixedUpdate

    public void moleWasClicked(){
        //sends 1 to the method addScore found in the ScoreManger Script
        scoreManager.AddScore(1);
        //Destroy this game object
        Destroy(gameObject);

    }

}
