using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;

public class OrangeBallScript : MonoBehaviour
{
    public BallManagerScript managerScript;
    [SerializeField] public GameObject orangeBall; 
    [SerializeField] public AudioSource source;
    public AudioClip [] audioClipArray;
    public int orangeCounter{get;  set;}
    void Start(){
        source.Stop();
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
        }else if(orangeCounter==3){
            orangeRandom();
        }else if(orangeCounter==4){
            orangeRandom();
        }else if(orangeCounter==5){
            orangeRandom();
        }
     }else{
            source.clip=audioClipArray[0];
            source.Play();
        }
    }

    public void orangeRandom(){
        Vector3 randomSpawnPosition=new Vector3(Random.Range(-7,8),4,Random.Range(-7,8));
        transform.position=randomSpawnPosition;
        orangeCounter++;
        managerScript.totalScore++;
        managerScript.orangeScore++;
    }
   }


