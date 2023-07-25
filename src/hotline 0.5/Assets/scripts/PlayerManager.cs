using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    InputManager inputManager;
    PlayerMotion playerMotion;

    private void Awake() //
    {
        inputManager = GetComponent<InputManager>(); //ми використовуємо всі ці скрипти на одному обєкті тому потрібно прописати що вони використовуються і читаються 
        playerMotion = GetComponent<PlayerMotion>();
    }

    private void Update()
    {
        inputManager.HandleAllInput();

    }
    private void FixedUpdate()
    {
        playerMotion.HandleAllMovement();
    }
}

