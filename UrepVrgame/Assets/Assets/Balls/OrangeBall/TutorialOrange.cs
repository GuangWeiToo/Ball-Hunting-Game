using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;

public class TutorialOrange : MonoBehaviour
{
    public TutorialManager managerTutorialScript;
    [SerializeField] public GameObject orangeBall; 
    public int orangeCounter{get;  set;}
        [SerializeField] public AudioSource source;
    public AudioClip [] audioClipArray;
    void Start(){
        
    }
   void OnCollisionEnter(Collision col){
    if(col.gameObject.name=="ReturnArea"){
        if(orangeCounter==0){
            orangeRandom();
          //  Instantiate(orangeBall,randomSpawnPosition,Quaternion.identity);
         //   Destroy(gameObject);
        }else if(orangeCounter==1){
            orangeRandom();
        }else if(orangeCounter==2){
            orangeRandom();
        }
     }else{
            source.clip=audioClipArray[0];
            source.Play();
        }
    }

    public void orangeRandom(){
        Vector3 randomSpawnPosition=new Vector3(-18,-2,-6);
        transform.position=randomSpawnPosition;
        orangeCounter++;
        managerTutorialScript.totalScore++;
        managerTutorialScript.orangeScore++;
    }
   }
