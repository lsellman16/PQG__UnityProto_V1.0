using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ClickMovement : MonoBehaviour
{
    [SerializeField] private InputAction mouseClickAction;
    
    private void Awake() 
    {
        mainCamera = Camera.Main;
    }

    private void OnEnable() 
    {
        mouseClickAction.Enable();
        mouseClickAction.performed += Move;    
    }

    private void OnDisable() {
        mouseClickAction.performed -= Move;
        mouseClickAction.Disable();
    }

    private void Move(InputAction.CallbackContext context)
    {
       Ray ray = mainCamera.ScreenPointToRay(Mouse.current.position.ReadValue());
       if (Physics.Raycast(ray: ray, hitInfo: out RaycastHit hit) && hit.collider) {

       }
    }
}
