using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.InputSystem;
using Vector2 = UnityEngine.Vector2;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    
    private PlayerInputAcion _playerInputAcion = null;

    private GroundDetection _groundDetection = null;
    
    private Vector2 _movementValue = Vector2.zero;

    private Rigidbody2D _rigidbody2D = null;

    [SerializeField] private float _runSpeed = 10.0f;

    [SerializeField] private float _jumpForce = 1.0f;

    private bool _isPressingUp;
    

    private void Awake()
    {
        _playerInputAcion = new PlayerInputAcion();
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _groundDetection = GetComponent<GroundDetection>();
        _isPressingUp = false;
    }


    private void Update()
    {
        if (_movementValue.y > 0 && _groundDetection.IsOnGround)
        {
            _isPressingUp = true;
        }
    }

    private void FixedUpdate()
    {
        _rigidbody2D.velocity = new Vector2(_movementValue.x * _runSpeed , _rigidbody2D.velocity.y);
        if (_isPressingUp)
        {
            Vector2 jump = new Vector2(0.0f, _jumpForce);
            _rigidbody2D.AddForce(jump,ForceMode2D.Impulse);
        }
        
        _isPressingUp = false;
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
