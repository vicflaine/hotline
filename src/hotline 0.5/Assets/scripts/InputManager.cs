using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour

   
{
    PalyerControl playerControl;


    public Vector2 movementInput; // виводимо значення вектора в х у на екран юніті
    public float verticalInput;
    public float horizontalInput;

    private void OnEnable()
    {
        if (playerControl == null) 
        {
            playerControl = new PalyerControl();

            playerControl.PlayerMovement.Movement.performed += i => movementInput = i.ReadValue<Vector2>(); //  читаємо wasd  і перетворюємо їх в координати 
        }
        playerControl.Enable();
    }
    private void OnDisable()
    {
        playerControl.Disable();
    }
    public void HandleAllInput()
    {
        HandleMovementInput();

    }

    private void HandleMovementInput() //  додаємо координати 
    {
        verticalInput = movementInput.y;
        horizontalInput = movementInput.x;

    }

}
