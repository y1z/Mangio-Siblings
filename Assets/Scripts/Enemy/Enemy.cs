using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;


[RequireComponent(typeof(Collider2D))]
public class Enemy : MonoBehaviour
{
    [SerializeField] public EnemyBehaviorData _data;
    
    [SerializeField] private Transform _starting_position = null;
    
    [SerializeField] private Transform _ending_position = null;
    
    [SerializeField] private CapsuleCollider2D _collider;
    
    [SerializeField] private Vector2 _currentTarget = Vector2.zero;
    
    [SerializeField] private float _speed = 1.0f;
    
    private Player _player_ref = null;
    

    private void Start()
    {
        _collider = GetComponent<CapsuleCollider2D>();
        _player_ref = FindObjectOfType<Player>();
        
        Assert.IsNotNull(_starting_position);
        Assert.IsNotNull(_ending_position);

        _data.StartingPosition = _starting_position.position;
        _data.TargetPosition= _ending_position.position;
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
            _data.TargetPosition = _data.StartingPosition;
            _data.StartingPosition = _currentTarget;
        }

        Vector2 delta = _data.TargetPosition - _data.StartingPosition;
        Vector2 current_position = transform.position ;
        current_position +=delta.normalized * (_speed * Time.deltaTime);
        transform.position = current_position ;
    }


    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.CompareTag("Player"))
        {
            _player_ref.setIsAlive(false);
            _player_ref.gameObject.SetActive(false);
        }
    }
}
