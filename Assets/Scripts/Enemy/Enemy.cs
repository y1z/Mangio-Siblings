using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Collider2D))]
public class Enemy : MonoBehaviour
{
    [SerializeField] public EnemyBehaviorData _data;
    [SerializeField] private CapsuleCollider2D _collider;
    [SerializeField] private Vector2 _currentTarget = Vector2.zero;
    [SerializeField] private float _speed = 1.0f;
    

    private void Start()
    {
        _collider = GetComponent<CapsuleCollider2D>();
    }


    private void Update()
    {
        if (_data.HasSetPath)
        {
            FollowSetPath();        
        }
        
    }


    private void FollowSetPath()
    {
        _currentTarget = _data.TargetPosition;


        if (Vector2.Distance(transform.position, _currentTarget) < _data.HowCloseCanIGetToTarget)
        {
            
        }


    }
}
