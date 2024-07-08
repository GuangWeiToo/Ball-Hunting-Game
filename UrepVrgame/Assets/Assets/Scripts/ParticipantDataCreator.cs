using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System.IO;
public class ParticipantDataCreator : MonoBehaviour
{
    public TMP_InputField participantN,Gender,DOB,Group,uniqueID;
    public GameObject DataField;
    public TMP_Text message;
    private string participantName, gender, dob,ID,group;
    // Start is called before the first frame update
    public void Start(){
        DontDestroyOnLoad(DataField);
        
        participantName=null; gender=null; dob=null; ID=null; group=null;
        message.text="Please enter your real info. Do not use false information or an alias name. For \"group \" please enter one exactly: A or B. If you feel uncomfortable, you may exit or pause the game. Note that if you exit, your study is concluded. Thank you for participating in this study, please enjoy your experience!";
    }
    //Name
    public void setName(string name){
        this.participantName=name;
    }
    public string getName(){
        return participantName;
    }
    //Gender
    public void setGender(string gender){
        this.gender=gender;
    }
    public string getGender(){
        return gender;
    }
    //DOB
    public void setDob(string Dob){
        this.dob=Dob;
    }
    public string getDob(){
        return dob;
    }
    public void setGroup(string Group){
        this.group=Group;
    }
    public string getGroup(){
        return group;
    }
    //Get ID
    public string getID(){
        return ID;
    }
    //When user press enter button
    public void enter(){
        participantName=participantN.text;
        gender=Gender.text;
        dob=DOB.text;
        group=Group.text;
        ID=uniqueID.text;
            //Check if all info input//Check if group type correctly
        if(((participantName.Equals(null))||(gender.Equals(null))||(dob.Equals(null))||(group.Equals(null))|| (ID.Equals(null)))&&((group!="None")||(group!="SingleNose")||(group!="VisonSnapper"))){
           // message.text="Please Enter All Your Info! For group.Please enter None, SingleNose, or VisionSnapper";
            return;
        }else{
            //Generate ID and name new folder with ID to store the scores later on
            //write in csv
        using(System.IO.StreamWriter file= new System.IO.StreamWriter("participants.csv",true)){
                file.WriteLine(ID+","+group+","+participantName+","+gender+","+dob);
        }
            
        //LoadScene
        SceneManager.LoadScene("Assets/AllScenes/Main Menu");
    
        }
    }

    /*
    public void generateID(){
        int newNum;
        for(int i=0;i<7;i++){
            
            newNum=Random.Range(0,9);
            this.ID=ID+(newNum.ToString());
        }
    }
    */
}
