using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class DisplayScores : MonoBehaviour
{
    public TextMeshPro ToTalScoreDisplay, ToTalTimeDisplay, rotationTimeDisplay;
    public GameObject ReturnArea,DataField,DistanceTracker;
    private ParticipantDataCreator data;
    public AudioSource audioSource;
    private BallManagerScript ballManager;
    // Start is called before the first frame update
    void Start()
    {
        audioSource.ignoreListenerPause = true;
        audioSource.ignoreListenerVolume = true;
        if (ReturnArea == null)
        {
            ReturnArea = GameObject.Find("ReturnArea");
            ballManager = ReturnArea.GetComponent<BallManagerScript>();
        }
        if(data==null){
            DataField=GameObject.Find("DataField");
            data=DataField.GetComponent<ParticipantDataCreator>();
            
        }
     
        ToTalTimeDisplay.text = ballManager.j.ToString();
        ToTalScoreDisplay.text = ballManager.totalScore.ToString();
        rotationTimeDisplay.text=ballManager.k.ToString();
        
        
            //Write time seconds played and next line total score
        using(System.IO.StreamWriter file= new System.IO.StreamWriter("DataField.csv",true)){
        file.WriteLine(
            data.getID()+","
            +ballManager.j.ToString()+","
            +ballManager.k.ToString()+","
            +ballManager.totalScore.ToString()+","
            +ballManager.redScore.ToString()+","
            +ballManager.blueScore.ToString()+","
            +ballManager.orangeScore.ToString()+","
            +ballManager.greenScore.ToString()+","
            +ballManager.cyanScore.ToString()+","
            +ballManager.getTotalDistance()+","
            +(ballManager.getTotalDistance()/60)
            );
        }
        // might have to merge displayScore script and ballCollected Script
    }

 
    
}
