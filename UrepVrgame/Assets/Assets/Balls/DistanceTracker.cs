using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceTracker : MonoBehaviour
{
    private Vector3 lastPosition;
    private float totalDistance,dps;
    [SerializeField]GameObject Camera,returnArea;

    BallManagerScript theManager;
 private void Start()
 {
    if(Camera==null){
        Camera= GameObject.Find("MainCameraField");
    }
    if(returnArea=null){
        returnArea=GameObject.Find("ReturnArea");
        theManager=returnArea.GetComponent<BallManagerScript>();
    }
     lastPosition = Camera.transform.position ;
 }
 
 private void Update()
 {
     float distance = Vector3.Distance( lastPosition, Camera.transform.position ) ;
     totalDistance += distance ;
     lastPosition =Camera.transform.position;
 }
 public float getTotalDistance(){
        return this.totalDistance;
   }
}
