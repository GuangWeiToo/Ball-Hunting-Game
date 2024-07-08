using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PositionUpdate : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject OrangeBall;
    public TextMeshProUGUI  TextPosition;

    // Update is called once per frame

    void Update()
    {
         TextPosition = GetComponent<TextMeshProUGUI>();
         LogMyPosition();
         
    }
    public void LogMyPosition(){
       TextPosition.text = "X:" + OrangeBall.transform.position.x+"\nY:" + OrangeBall.transform.position.y+"\nZ:" + OrangeBall.transform.position.z;
     }
}
