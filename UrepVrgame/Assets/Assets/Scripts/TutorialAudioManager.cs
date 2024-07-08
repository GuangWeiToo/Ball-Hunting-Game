using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialAudioManager : MonoBehaviour
{
  [SerializeField] TutorialManager tManager;
  [SerializeField] AudioSource audioP;

  public AudioClip[] audioClipArray;
  int previousScore=-1,currentScore,nextScore;
    
   
    public void playAudio(int currentScore){
            audioP.Stop();
            audioP.clip=audioClipArray[currentScore];
            audioP.Play();
    }
    // Update is called once per frame
    void Update()
    {
        currentScore=tManager.totalScore;
       if(previousScore==currentScore){
        if(currentScore==nextScore){
        playAudio(currentScore);
        nextScore++;
        }
        
       }else{
         previousScore++;
       }
    }
}
