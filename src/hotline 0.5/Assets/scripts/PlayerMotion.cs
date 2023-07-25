using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotion : MonoBehaviour
{
    InputManager inputManager;

    Vector3 moveDirection;
    Transform cameraObject;
    Rigidbody2D playerRigidbody2D;

    public float movementSpeed = 7;

    public void HandleAllMovement()
    {
        HandleMovement();

    }
    private void Awake()
    {
        inputManager = GetComponent<InputManager>();
        playerRigidbody2D = GetComponent<Rigidbody2D>();
        cameraObject = Camera.main.transform;  // даємо значення камери в юніті як тег mainCamera
    }
    private void HandleMovement()
    {
        moveDirection = cameraObject.up * inputManager.verticalInput; // горизнтальний рух
        moveDirection = moveDirection + cameraObject.right * inputManager.horizontalInput;//вертикальний рух
        moveDirection.Normalize();
       
        moveDirection = moveDirection * movementSpeed; // формула для швидкості

        Vector3 movementVelocity = moveDirection;
        playerRigidbody2D.velocity = movementVelocity;
    }
}
