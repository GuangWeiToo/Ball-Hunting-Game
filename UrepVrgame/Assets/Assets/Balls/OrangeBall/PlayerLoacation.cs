using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerLoacation : MonoBehaviour
{
    [SerializeField] GameObject MainCamera;
    public TextMeshProUGUI  TextPosition;

    // Update is called once per frame

    void Update()
    {
         TextPosition = GetComponent<TextMeshProUGUI>();
         LogMyPosition();
         
    }
    public void LogMyPosition(){
       TextPosition.text = "X:" + MainCamera.transform.position.x+"\nY:" + MainCamera.transform.position.y+"\nZ:" + MainCamera.transform.position.z;
     }
}
