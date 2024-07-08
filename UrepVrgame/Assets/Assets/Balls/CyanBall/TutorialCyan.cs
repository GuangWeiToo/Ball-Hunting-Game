using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialCyan : MonoBehaviour {
    public TutorialManager managerTutorialScript;
    public GameObject[] waypoints;
    public GameObject waypoint1;
    public GameObject waypoint2;
    public GameObject cyanBall;
    int current = 0;
    public int cyanCounter{get; set;}
    public float speed;
    float WPradius = 1;
	void Start(){
        
    }
	void Update () {
        if(Vector3.Distance(waypoints[current].transform.position, transform.position) < WPradius){
            current = Random.Range(0,waypoints.Length);
            if (current >= waypoints.Length){
                current = 0;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);

        }
    void OnCollisionEnter(Collision col){
        if(col.gameObject.name=="ReturnArea"){  
        //changePoints();
        cyanCounter++;
        managerTutorialScript.totalScore++;
        managerTutorialScript.cyanScore++;
        Debug.Log("CyanBall ran"+ cyanCounter);
        }
    }
    public void changePoints(){
        Vector3 wayppoint1SpawnPosition=new Vector3(Random.Range(-2,2),-2,Random.Range(-2,2));
        Vector3 wayppoint2SpawnPosition=new Vector3(Random.Range(-2,2),-2,Random.Range(-2,2));
        waypoint1.transform.position+= wayppoint1SpawnPosition;
        waypoint2.transform.position+= wayppoint2SpawnPosition;
    }
    }
