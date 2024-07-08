using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;
public class PauseScreen : MonoBehaviour
{
    public InputActionReference toggleRight=null;
    public InputActionReference toggleLeft=null;
    public GameObject pauseScreen;
    // Start is called before the first frame update
    private void Awake()
    {

        toggleRight.action.started+= pauseGame;//Activate
        toggleLeft.action.started+= pauseGame;//Activate
        pauseScreen.gameObject.SetActive(false);
    }

    private void OnDestroy(){
        toggleRight.action.started-= pauseGame;
        toggleLeft.action.started-= pauseGame;
    }
    // Update is called once per frame
 void pauseGame(InputAction.CallbackContext context){
    bool isActive= !pauseScreen.activeSelf;
    pauseScreen.SetActive(isActive);
    if(isActive){
    Time.timeScale=0;
    AudioListener.pause=true;
    }else{
    Time.timeScale=1;
    AudioListener.pause=false;
    }
 }
}

