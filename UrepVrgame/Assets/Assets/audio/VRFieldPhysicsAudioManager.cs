using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System;


public class VRFieldPhysicsAudioManager : MonoBehaviour
{
    System.Random ran=new System.Random();
    [SerializeField]AudioSource source;
    public AudioClip [] audioClipArray;
    public InputActionReference movement=null;

    private void Update(){
        int value=movement.action.ReadValue<int>();
        Move(value);
       
    }
    private void Move(int value){
        int num=ran.Next(0,6);
        source.clip= audioClipArray[num];
        source.Play();
    }
  
}
