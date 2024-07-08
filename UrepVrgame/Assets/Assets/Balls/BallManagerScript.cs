using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class BallManagerScript : MonoBehaviour
{
    [SerializeField] GameObject ReturnArea;
    public TextMeshPro scoreCounterText, redCounterText, blueCounterText, orangeCounterText, greenCounterText, cyanCounterText, indicatorText;
    public int totalScore, redScore, blueScore, orangeScore, greenScore, cyanScore;
    public int redTime,blueTime, orangeTime, greenTime, cyanTime;
    private float timer=0.0f;
    public int j,k;
    int ballType;
    public bool finishRotation,gamePaused=false;
    public RedBall redScript;
    public BlueBall blueScript;
    public TimerBall timerScript;
    public OrangeBallScript orangeScript;
    public CyanBall cyanScript;
    private float totalDistance;
     public GameObject redGameObject, blueGameObject, orangeGameObject, greenGameObject,cyanGameObject;
     DistanceTracker tracker;
   
   //Takes Distance tracker script value and set to ball manager totaldistance
  
    // Start is called before the first frame update

    // Update is called once per frame
    ParticleSystem ps;
    [SerializeField] public AudioSource source;
    public AudioClip [] audioClipArray;
    void Start(){
        ps=GameObject.Find("BirthdayConfetti").GetComponent<ParticleSystem>();
            indicatorText.SetText("Find the Red Ball");
            DontDestroyOnLoad(ReturnArea);
            blueGameObject.SetActive(false);
            orangeGameObject.SetActive(false);
            greenGameObject.SetActive(false);
            cyanGameObject.SetActive(false);
            ballType=1;
            tracker=GameObject.Find("DistanceTracker").GetComponent<DistanceTracker>();
    }
    void OnCollisionEnter(Collision col){
        if((col.gameObject.name=="CyanBall_1")||(col.gameObject.name=="BlueBall")||(col.gameObject.name=="OrangeBall")||(col.gameObject.name=="GreenBall")||(col.gameObject.name=="RedBall")){
            ps.Play();
            source.clip=audioClipArray[0];
            source.Play();
        }
    }
    void Update()
    {
        totalDistance=tracker.getTotalDistance();
        //Timer Spent in game
        if(!gamePaused){
        timer += Time.deltaTime;
        j=(int) timer;
        }
        //Rotation Time
        if(!gamePaused && !finishRotation){
        timer += Time.deltaTime;
        k=(int) timer;
        }
        scoreCounterText.text= totalScore.ToString();
        redCounterText.text= redScore.ToString();
        blueCounterText.text=blueScore.ToString();
        orangeCounterText.text=orangeScore.ToString();
        greenCounterText.text=greenScore.ToString();
        cyanCounterText.text= cyanScore.ToString();

        if(redScript.redCounter==redTime){
            redScript.redCounter=0;
            redGameObject.SetActive(false);
            blueGameObject.SetActive(true);
            indicatorText.SetText("Find the Blue Ball");
            ballType=2;
        }
        if(blueScript.blueCounter==blueTime){
            blueScript.blueCounter=0;
           blueGameObject.SetActive(false);
            orangeGameObject.SetActive(true);
            indicatorText.SetText("Find the Orange Ball");
            ballType=3;
        }
         if(orangeScript.orangeCounter==orangeTime){
             orangeScript.orangeCounter=0;
            orangeGameObject.SetActive(false);
            greenGameObject.SetActive(true);
            indicatorText.SetText("Find the Green Ball");
            ballType=4;
        }
        if(timerScript.greenCounter==greenTime){
            timerScript.greenCounter=0;
            greenGameObject.SetActive(false);
            cyanGameObject.SetActive(true);
            indicatorText.SetText("Find the Cyan Ball");
            ballType=5;
        }
        if(cyanScript.cyanCounter==cyanTime){
            cyanScript.cyanCounter=0;
            cyanGameObject.SetActive(false);
            redGameObject.SetActive(true);
            indicatorText.SetText("Find the Red Ball");
            ballType=1;
            finishRotation=true;//stop rotation time
        }
    
    }
    public float getTotalDistance(){
        return this.totalDistance;
   }
   public int getBallType(){
    return this.ballType;
   }
}
