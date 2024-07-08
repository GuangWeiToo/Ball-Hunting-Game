using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class Window : MonoBehaviour
{
    public InputActionReference toggleRef=null;
    // Start is called before the first frame update
    [SerializeField] GameObject window;
    [SerializeField] GameObject XROrigin;
    //private bool windowActive = false;
    void Start(){
        CharacterControllerDriver characterControllerDriver = XROrigin.GetComponent<CharacterControllerDriver>();
        characterControllerDriver.minHeight=1;
    }
    private void Awake()
    {
        toggleRef.action.started+= ActivateWindow;//Activate
       window.gameObject.SetActive(false);
    }

    private void OnDestroy(){
        toggleRef.action.started-= ActivateWindow;
    }
    // Update is called once per frame
   private void ActivateWindow(InputAction.CallbackContext context)
    {
            bool isActive= !window.activeSelf;
            window.SetActive(isActive);
    }
}