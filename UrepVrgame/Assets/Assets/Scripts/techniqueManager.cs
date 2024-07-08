using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class techniqueManager : MonoBehaviour
{
    [SerializeField] GameObject singleNose;
    [SerializeField] GameObject visionSnapper;
    GameObject participantData;
    GameObject locomotion;
    ParticipantDataCreator groupData;
    ActionBasedContinuousTurnProvider turnXR;

    // Start is called before the first frame update
     public void Start(){
          if(participantData==null){
               participantData=GameObject.Find("DataField");
               groupData=participantData.GetComponent<ParticipantDataCreator>();
               locomotion=GameObject.Find("Locomotion System (2)");
               turnXR=locomotion.GetComponent<ActionBasedContinuousTurnProvider>();
          }
          if(groupData.getGroup().Equals("A")){
               SingleNose();
          }else if(groupData.getGroup().Equals("B")){
               None();
          }else if(groupData.getGroup().Equals("C")){
               VisionSnapper();
               turnXR.enabled=false;
          }
     }
   public void SingleNose(){
        singleNose.SetActive(true);
        visionSnapper.SetActive(false);
   }
   public void VisionSnapper(){
        singleNose.SetActive(false);
        visionSnapper.SetActive(true);
   }

   public void None(){
        singleNose.SetActive(false);
        visionSnapper.SetActive(false);
   }

}
