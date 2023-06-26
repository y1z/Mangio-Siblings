using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    private PlayerInputAcion _playerInputAcion = null;
    
    private Vector2 _movementValue = Vector2.zero;

    private Rigidbody2D _rigidbody2D = null;

    [SerializeField] private float _runSpeed = 1.0f;
    [SerializeField] private float _runSpeedIncrement;  


    private float _jumpForce = 1.0f;

    private void Awake()
    {
        _playerInputAcion = new PlayerInputAcion();
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _runSpeedIncrement = _runSpeed * 0.10f;
    }

    private void Update()
    {
        float run_factor = _runSpeed * _movementValue.x;


    }

    private void OnEnable()
    {
       _playerInputAcion.Enable(); 
       // subscribe to the function that takes care of the movement. 
       _playerInputAcion.Player.Movement.performed += OnPlayerMovement;
       _playerInputAcion.Player.Movement.canceled += OnPlayerMovement;
    }

    private void OnDisable()
    {
       _playerInputAcion.Disable(); 
       
       _playerInputAcion.Player.Movement.performed -= OnPlayerMovement;
       _playerInputAcion.Player.Movement.canceled -= OnPlayerMovement;
    }


    private void OnPlayerMovement(InputAction.CallbackContext value)
    {
        _movementValue = value.ReadValue<Vector2>();
    }

    private void OnPlayerMovementCancelled(InputAction.CallbackContext value)
    {
        
    }
    
}
