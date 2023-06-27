using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BetterJump : MonoBehaviour
{
    private const float GRAVITY_MULTIPILER = 1.25f;
    
    private Rigidbody2D _rigidbody2D = null;
    [SerializeField]
    private float _gravityMultipiler = GRAVITY_MULTIPILER;


    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Vector2 velocity_copy = _rigidbody2D.velocity;  
        float falling_speed = velocity_copy.y;
        
        if (falling_speed < 0.0f )
        {
            // using Vector2.up to manipulate the y axis
            _rigidbody2D.velocity += Vector2.up * (Physics.gravity.y * (_gravityMultipiler - 1.0f) * Time.fixedDeltaTime);
        }

    }
}
