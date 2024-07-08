using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TutorialManager : MonoBehaviour
{
    public TextMeshPro scoreCounterText, redCounterText, blueCounterText, orangeCounterText, greenCounterText, cyanCounterText;
    public int totalScore, redScore, blueScore, orangeScore, greenScore, cyanScore;
    public int redTime,blueTime, orangeTime, greenTime, cyanTime;
    public TutorialRed redTutorialScript;
    public TutorialBlue blueTutorialScript;
    public TutorialGreen timerTutorialScript;
    public TutorialOrange orangeTutorialScript;
    public TutorialCyan cyanTutorialScript;

    public GameObject tutorialExit;
     public GameObject redGameObject;
     public GameObject blueGameObject;
     public GameObject orangeGameObject;
     public GameObject greenGameObject;
     public GameObject cyanGameObject;
    // Start is called before the first frame update

    // Update is called once per frame
    void Start(){
            blueGameObject.SetActive(false);
            orangeGameObject.SetActive(false);
            greenGameObject.SetActive(false);
            cyanGameObject.SetActive(false);
            tutorialExit.SetActive(false);
    }

    void Update()
    {
        if(totalScore==(redTime+blueTime+orangeTime+greenTime+cyanTime)){
            tutorialExit.SetActive(true);
        }
        scoreCounterText.text= totalScore.ToString();
        redCounterText.text= redScore.ToString();
        blueCounterText.text=blueScore.ToString();
        orangeCounterText.text=orangeScore.ToString();
        greenCounterText.text=greenScore.ToString();
        cyanCounterText.text= cyanScore.ToString();

        if(redTutorialScript.redCounter==redTime){
            redTutorialScript.redCounter=0;
            redGameObject.SetActive(false);
            blueGameObject.SetActive(true);
        }
        if(blueTutorialScript.blueCounter==blueTime){
            blueTutorialScript.blueCounter=0;
           blueGameObject.SetActive(false);
            orangeGameObject.SetActive(true);
        }
         if(orangeTutorialScript.orangeCounter==orangeTime){
             orangeTutorialScript.orangeCounter=0;
            orangeGameObject.SetActive(false);
            greenGameObject.SetActive(true);
        }
        if(timerTutorialScript.greenCounter==greenTime){
            timerTutorialScript.greenCounter=0;
            greenGameObject.SetActive(false);
            cyanGameObject.SetActive(true);
        }
        if(cyanTutorialScript.cyanCounter==cyanTime){
            cyanTutorialScript.cyanCounter=0;
            cyanGameObject.SetActive(false);
            redGameObject.SetActive(true);
        }
    
    }
}
