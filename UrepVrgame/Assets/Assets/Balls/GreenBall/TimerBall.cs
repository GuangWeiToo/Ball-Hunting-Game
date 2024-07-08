using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;
public class TimerBall : MonoBehaviour
{
    public BallManagerScript managerScript;
    [SerializeField] public GameObject greenBall; 
    [SerializeField] public float counter;
    [SerializeField] public AudioSource source;
    public AudioClip [] audioClipArray;
    int j;
    public int greenCounter{get; set;}

     float timer = 0.0f;

    // Start is called before the first frame update
    void Start(){
        source.Stop();
    }
    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;
        j=(int) timer % 60;
        
        if(j==counter){
            Debug.Log("Green Ball gone");
            Vector3 randomSpawnPosition=new Vector3(Random.Range(-7,8),4,Random.Range(-7,8));
            transform.position=randomSpawnPosition;
        }
    }
    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.name=="ReturnArea"){
            Debug.Log("Green Ball picked up");
            greenCounter++;
            managerScript.totalScore++;
            managerScript.greenScore++;
            Vector3 randomSpawnPosition=new Vector3(Random.Range(-7,8),4,Random.Range(-7,8));
            transform.position=randomSpawnPosition;
        }else{
            source.clip=audioClipArray[0];
            source.Play();
        }
    }
}

