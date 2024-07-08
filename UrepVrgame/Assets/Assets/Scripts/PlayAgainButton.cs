using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgainButton : MonoBehaviour
{
        ParticipantDataCreator participantReset;
        DistanceTracker distanceReset;
        BallManagerScript managerReset;
    
    public void reset(){
        //SET EVERY VARIABLE TO NULL TO RESET SINCE DESTROY REmOVES GAMEOBJECT AND SCRIPT NOT RESET
        //1)GET SCRIPT
        GameObject DataField=GameObject.Find("DataField");
        participantReset=DataField.GetComponent<ParticipantDataCreator>();
        //2)ACCESS VARIABLES//3)SET TO 0 OR NULL
        participantReset.setName("null");participantReset.setGender("null");participantReset.setDob("null");participantReset.setGroup("null");
    }
    public void playAgainButton(){
        Time.timeScale=1;
        GameObject ReturnArea= GameObject.Find("ReturnArea");
        managerReset=ReturnArea.GetComponent<BallManagerScript>();
        managerReset.redScore=0;managerReset.blueScore=0;managerReset.orangeScore=0;managerReset.greenScore=0;managerReset.cyanScore=0;managerReset.totalScore=0;
        ReturnArea.SetActive(false);
        reset();
        SceneManager.LoadScene("Assets/AllScenes/ParticipantInput");
    }
    public void playAgainTutorialButton(){
        Time.timeScale=1;
        reset();
        SceneManager.LoadScene("Assets/AllScenes/Main Menu");
    }
}
