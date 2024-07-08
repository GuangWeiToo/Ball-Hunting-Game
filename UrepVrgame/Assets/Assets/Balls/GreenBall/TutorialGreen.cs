using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;
public class TutorialGreen : MonoBehaviour
{
    public TutorialManager managerTutorialScript;
    [SerializeField] public GameObject greenBall; 
    [SerializeField] public float counter;
        [SerializeField] public AudioSource source;
    public AudioClip [] audioClipArray;
    int j;
    public int greenCounter{get; set;}

     float timer = 0.0f;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;
        j=(int) timer % 60;;
        
        if(j==counter){
            Debug.Log("Green Ball gone");
            Vector3 randomSpawnPosition=new Vector3(-18,-2,-6);
            transform.localPosition=randomSpawnPosition;
        }
    }
    void OnCollisionEnter(Collision col){
        if(col.gameObject.name=="ReturnArea"){
            Debug.Log("Green Ball picked up");
            greenCounter++;
            managerTutorialScript.totalScore++;
            managerTutorialScript.greenScore++;
            Vector3 randomSpawnPosition=new Vector3(-18,-2,-6);
            transform.localPosition=randomSpawnPosition;
        }else{
            source.clip=audioClipArray[0];
            source.Play();
        }
    }
}