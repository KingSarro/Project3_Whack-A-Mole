using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleSpawner : MonoBehaviour{
    //Get refernces for the prefab of the mole object
    [SerializeField] GameObject molePrefab;
    //Gets a ference to the object I want to use as the parent objects (MoleSpawner Canvas)
    [SerializeField] GameObject parentObject;
    //Initalized variables to hold the height and width of the canvas
    float rectHeight, rectWidth;

    // Start is called before the first frame update//Vars used to keep track when to spawn the next mole
    [SerializeField] private float secsTillSpawn = 5f;
    private float timerCount = 0f;

    void Start(){
        //Gets the heigh and width of the RectTransform
        rectHeight = GetComponent<RectTransform>().rect.height;
        rectWidth = GetComponent<RectTransform>().rect.width;
        //Calls the spawnMole function
        spawnMole();
    }

    //This update is used to count the seconds of how long this mole is around
    void FixedUpdate(){
        //Adds a second to timerCount
        timerCount += Time.deltaTime;

        //Checks if the timer reaches the secTillDespawn. 
        //If they do...
        if(timerCount >= secsTillSpawn){
            //Spawn in a new mole
            spawnMole();
            //Resets the counter
            timerCount = 0f;
        }//closes timer check
    }//closes fixedUpdate

    float getRanNum(int widthOrHeight){
        //Gets a random number for the height or width of the object
        float r = (widthOrHeight == 1) ? Random.Range(0, rectWidth): Random.Range(0,rectHeight);
        //return r
        return r;
    }

    void spawnMole(){
        //Instantiate a new gameobject and saves a refernce to it
        GameObject mPrefab = Instantiate(molePrefab);
        //Sets the parent of the instatiated gameobject
        mPrefab.transform.SetParent(parentObject.transform);
        //Changes the position of the instatiated game object
        mPrefab.transform.position = new Vector3(getRanNum(1), getRanNum(2), 0);
    }
}
