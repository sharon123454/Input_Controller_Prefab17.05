using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using System;
using UnityEngine.InputSystem.iOS;

public class Player : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private float _speed = 10;

    private void Start()
    {
        Controller.Instance.Interact.started += Controller_Interact;
    }

    void Update()
    {
        transform.Translate(Controller.Instance.GetMoveDirection(transform) * _speed * Time.deltaTime);
    }
    
    private void Controller_Interact(InputAction.CallbackContext context)
    {
        print("Interact Pressed");
    }

}