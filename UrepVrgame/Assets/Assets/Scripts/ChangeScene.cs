using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    GameObject returnArea;
    // Update is called once per frame
    void OnTriggerEnter(Collider collider){
        if(collider.gameObject.tag=="Player"){
            returnArea= GameObject.Find("ReturnArea");
            returnArea.SetActive(true);
            SceneManager.LoadScene("VRField");
        }
    }
}
