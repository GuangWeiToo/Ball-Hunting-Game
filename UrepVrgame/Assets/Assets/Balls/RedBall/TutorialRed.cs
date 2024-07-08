using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TutorialRed : MonoBehaviour
{
    public TutorialManager managerTutorialScript;
    [SerializeField] public GameObject redBall;
    public int redCounter{get; set;}
        [SerializeField] public AudioSource source;
    public AudioClip [] audioClipArray;


    // Update is called once per frame
    void Start(){
        transform.localPosition = new Vector3(-16,-2, -6);
    }
     IEnumerator wait()
      {
          yield return new WaitForSeconds(5);
    
      }
   void OnCollisionEnter(Collision col){
    if(col.gameObject.name=="ReturnArea"){
        if(redCounter==0){
            spaceRedBall(-16,-6);
            StartCoroutine(wait());      
        }  
        else if(redCounter==1){
            spaceRedBall(-16,-6);
            StartCoroutine(wait());      
        }
   }else{
            source.clip=audioClipArray[0];
            source.Play();
        }
   }

    public int spaceRedBall(int x, int z){
        redBall.transform.localPosition = new Vector3(x,-2, z);
        managerTutorialScript.totalScore++;
        managerTutorialScript.redScore++;
        redCounter++;
        return redCounter;
    }
}