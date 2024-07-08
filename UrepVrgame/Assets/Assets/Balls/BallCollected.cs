using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BallCollected : MonoBehaviour
{
    public GameObject returnArea;
    BallManagerScript ballManager;
    public TextMeshPro redScore, blueScore, orangeScore, greenScore, cyanScore;

    // Start is called before the first frame update
    void Start()
    {
        if(returnArea== null || ballManager==null){
           returnArea = GameObject.Find("ReturnArea");
           ballManager= returnArea.GetComponent<BallManagerScript>();
        }
        ballCountDisplay();
    }

    void ballCountDisplay(){
        redScore.text= ballManager.redScore.ToString();
        blueScore.text= ballManager.blueScore.ToString();
        orangeScore.text= ballManager.orangeScore.ToString();
        greenScore.text= ballManager.greenScore.ToString();
        cyanScore.text= ballManager.cyanScore.ToString();
    }
}
