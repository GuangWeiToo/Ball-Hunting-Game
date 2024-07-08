using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FPSUIScript : MonoBehaviour
{
    public GameObject DataField;
    private ParticipantDataCreator data;
    public TextMeshProUGUI fpsText;
    private float time;
    private float pollingTime=1f;
    private int frameCounter;

    void Start(){
        if(data==null){
            DataField=GameObject.Find("DataField");
            data=DataField.GetComponent<ParticipantDataCreator>();
        }
        using(System.IO.StreamWriter file= new System.IO.StreamWriter("FPSRecord.csv",true)){
            file.WriteLine("\nID:"+data.getID());
        }
    }
    // Update is called once per frame
    void Update()
    {
    time+=Time.deltaTime;
    frameCounter++;
    if(time>=pollingTime){
        int frameRate=Mathf.RoundToInt(frameCounter/time);
        fpsText.text=frameRate.ToString()+"FPS";
        using(System.IO.StreamWriter file= new System.IO.StreamWriter("FPSRecord.csv",true)){
            file.Write(frameRate.ToString()+",");
        }
        time-=pollingTime;
        frameCounter=0;
    }

    }
}
