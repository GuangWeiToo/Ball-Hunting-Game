using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
public class MoleFinder : MonoBehaviour
{
    // Start is called before the first frame update
    public InputActionReference toggleRight=null;
    [SerializeField] GameObject moleObject;
    [SerializeField] TextMeshPro text;
    int useAvailable=3;

    private GameObject mole,player;
    BallManagerScript script;
    Mole moleScript;
    private void Awake()
    {
        script= GameObject.Find("ReturnArea").GetComponent<BallManagerScript>();
        mole= GameObject.Find("Free Burrow");
        moleScript=mole.GetComponent<Mole>();
        player=GameObject.Find("XR Origin");
        toggleRight.action.started+= useMole;//Activate
        text.SetText(useAvailable.ToString());
        moleObject.gameObject.SetActive(false);
    }

    private void OnDestroy(){
        toggleRight.action.started-= useMole;

    }
    // Update is called once per frame
 void useMole(InputAction.CallbackContext context){
        bool isActive= !moleObject.activeSelf;
        moleObject.SetActive(isActive);
        moleObject.GetComponent<Mole>().enabled=isActive;
        
        if(isActive &&(useAvailable>0)){
            mole.transform.localPosition = player.transform.position;
            moleScript.getBall(script.getBallType());
            useAvailable--;
            text.SetText(useAvailable.ToString());
        }else{
            //print no uses left and return
            gameObject.SetActive(false);
        }
    }

 
}
