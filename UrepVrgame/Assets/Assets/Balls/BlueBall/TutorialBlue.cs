using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class TutorialBlue : MonoBehaviour
{
    public TutorialManager managerTutorialScript;
    public float speed;
     [SerializeField] private GameObject blueBall;
    public int blueCounter {get; set;}
    public Transform point; 
    //reminder here to create an object called "point" as the reference for the "center"
    // Start is called before the first frame update
    //initialize

    /*
    public InputActionReference toggleLeft=null;
    public InputActionReference toggleRight=null;
    bool notGrabbed;
    private void Awake()
    {
        blueBall.GetComponent<Rigidbody>().useGravity=false;
        toggleLeft.action.started+= Grabbed;//Activate
        toggleRight.action.started+= Grabbed;
    }

    private void OnDestroy(){
        toggleLeft.action.started-= Grabbed;
        toggleRight.action.started-= Grabbed;
    }
    void Grabbed(InputAction.CallbackContext context){
        notGrabbed=false;
        XRGrabInteractable grabScript= blueBall.GetComponent<XRGrabInteractable>();
        bool selected=grabScript.isSelected;
        if((!notGrabbed) && selected){
            blueBall.GetComponent<Rigidbody>().useGravity=true;
            this.speed=0;
        }
    }
    */
void Update () { 
        transform.RotateAround(point.position, Vector3.up, speed*Time.deltaTime);
}
void OnCollisionEnter(Collision col){
if(col.gameObject.name=="ReturnArea"){
setCounter();
Vector3 SpawnPosition=new Vector3(-5,-1,14);
transform.position=SpawnPosition;
}
}
public void setCounter(){
    blueCounter++;
    managerTutorialScript.totalScore++;
    managerTutorialScript.blueScore++;
    Debug.Log("Blue Ball picked up");
}
}
