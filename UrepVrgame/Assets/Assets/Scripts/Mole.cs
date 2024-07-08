using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;   

public class Mole : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject activeBall, mole;
    private Animation moleAnim;
    private NavMeshAgent moleNav;

    void Start()
    {
        moleNav=GetComponent<NavMeshAgent>();
        mole=GameObject.Find("Free Burrow");
        getBall(GameObject.Find("ReturnArea").GetComponent<BallManagerScript>().getBallType());
    }

    void FixedUpdate(){
        if(!activeBall.activeInHierarchy){
            activeBall=null;
            gameObject.SetActive(false);
        }
        if(!moleNav.pathPending && moleNav.remainingDistance<.5f){
        // play jump animation state when ball reached
        Debug.Log("Squeak");
        }
        mole.transform.LookAt(activeBall.transform);
        moleNav.destination = activeBall.transform.position; 
        
        //mole.transform.position= Vector3.MoveTowards(transform.position,activeBall.transform.position,Time.deltaTime);
        //moleAnim.Play("Walk Forward In Place");
    
    }
   public void getBall(int activeBallNum){
    
        //check which ball is active and set that as objective
        switch (activeBallNum){
            case 1:
                this.activeBall=GameObject.Find("RedBall");
            break;
            case 2:
                this.activeBall=GameObject.Find("BlueBall");
            break;
            case 3:
                this.activeBall=GameObject.Find("OrangeBall");
            break;
            case 4:
                this.activeBall=GameObject.Find("GreenBall");
            break;
            case 5:
                this.activeBall=GameObject.Find("CyanBall_1");
            break;
       
        }
}
}

/*
if(!moleNav.pathPending && moleNav.remainingDistance<.5f){
        // play jump animation state when ball reached
        Debug.Log("Sqeak");
        }
*/