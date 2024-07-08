using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairBehavior : MonoBehaviour
{
    [SerializeField] public AudioSource source;
    public AudioClip [] audioClipArray;

    void Awake(){
        source.Stop();
    }
   void OnCollisionEnter(Collision col){
    source.clip=audioClipArray[0];
    source.Play();
   }
}
