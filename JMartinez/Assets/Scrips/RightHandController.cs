using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class RightHandController : MonoBehaviour
{

    // estado
    public InputActionReference JoyStick_North_Reference;

    // right controller - grab

    public ActionBasedController actionBasedController_grab;
    public XRRayInteractor xRRayInteractor_grab;
    public LineRenderer lineRenderer_grab;
    public XRInteractorLineVisual interactorLineVisual_grab;

    //right controller - teleport

    public ActionBasedController actionBasedController_teleport;
    public XRRayInteractor xRRayInteractor_teleport;
    public LineRenderer lineRenderer_teleport;
    public XRInteractorLineVisual interactorLineVisual_teleport;
    
    // metodos propios 

    public void JoyStickArribaPresionado(InputAction.CallbackContext context)
    {
        xRRayInteractor_grab.enabled = false;
        //-------------------
        xRRayInteractor_teleport.enabled = true;
        interactorLineVisual_teleport.enabled= true;

}

public void JoyStickArribaLiberado(InputAction.CallbackContext context)
    {
        xRRayInteractor_grab.enabled = true;
        //-------------
        xRRayInteractor_teleport.enabled = false;
        interactorLineVisual_teleport.enabled = false;
    }
    // metodos heredados

    private void OnEnable()
    {
        JoyStick_North_Reference.action.performed += JoyStickArribaPresionado;
        JoyStick_North_Reference.action.canceled += JoyStickArribaLiberado;
    }
    private void OnDisable()
    {
        JoyStick_North_Reference.action.performed -= JoyStickArribaPresionado;
        JoyStick_North_Reference.action.canceled -= JoyStickArribaLiberado;
    }
}
