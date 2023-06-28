using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class GroundDetection : MonoBehaviour
{
    public Transform _playerFeetPosition = null;
    
    [SerializeField] private LayerMask _mask;

    [SerializeField] private float _circle_radius = 0.2f;

    private bool is_on_ground;

    
    private void Awake()
    {
       _mask.value = 0;
       _mask.value = (1 << LayerMask.NameToLayer("Ground")) | (1 << LayerMask.NameToLayer("Jumpbable"));
       is_on_ground = false;
       Assert.IsNotNull(_playerFeetPosition,"You need to set a transform for this script to work");
    }

    private void Update()
    {
        is_on_ground = Physics2D.OverlapCircle(_playerFeetPosition.position, _circle_radius, _mask);
    }

    public bool IsOnGround => is_on_ground;
}
