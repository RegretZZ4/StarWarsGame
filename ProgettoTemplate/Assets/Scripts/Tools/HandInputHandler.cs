using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.SceneManagement;


/// <summary>
/// Agganciare questo script ai controller vr
/// </summary>

[RequireComponent(typeof(XRBaseController))]
public class HandInputHandler : MonoBehaviour
{
    
    protected XRBaseController controller;
    [SerializeField]
    protected InputActionReference RestartAction;
 


    void Awake()
    {
        controller = GetComponent<XRBaseController>();
        RestartAction.action.performed += Restart;
    }

    private void Restart(InputAction.CallbackContext obj)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    /// <summary>
    /// Per utilizzare la vibrazione del controller
    /// NOTA: se si utilizza la vibrazione agganciare questo component SEMPRE al controller
    /// </summary>
    /// <param name="amplitude"></param>
    /// <param name="duration"></param>
    public void SendHapticImpulse(float amplitude, float duration)
    {
        controller.SendHapticImpulse(amplitude, duration);
    }

}
