using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RedBall : MonoBehaviour
{
    public BallManagerScript managerScript;
    [SerializeField] private GameObject redBall;
    [SerializeField] public AudioSource source;
    public AudioClip [] audioClipArray;
    public int redCounter{get; set;}
    
    // Update is called once per frame
    void Start(){
        source.Stop();
        redBall.transform.localPosition=new Vector3(-3,50,-14);
    }
     IEnumerator wait()
      {
          yield return new WaitForSeconds(5);
    
      }
   void OnCollisionEnter(Collision col){
    if(col.gameObject.name=="ReturnArea"){
        if(redCounter==0){
            spaceRedBall(-4,-18);
            StartCoroutine(wait());      
        }  
        else if(redCounter==1){
            spaceRedBall(-9,-19);
            StartCoroutine(wait());      
        }
        else if(redCounter==2){
            spaceRedBall(-4,-26);
            StartCoroutine(wait());      
        }
        else if(redCounter==3){
            spaceRedBall(-4,-10);
            StartCoroutine(wait());      
        }
        else if(redCounter==4){
            spaceRedBall(-4,-28);
            StartCoroutine(wait());      
        }
    }else{
            source.clip=audioClipArray[0];
            source.Play();
        }
   }

    public int spaceRedBall(int x, int z){
        redBall.transform.localPosition = new Vector3(x,50, z);
        managerScript.totalScore++;
        managerScript.redScore++;
        redCounter++;
        return redCounter;
    }
}


