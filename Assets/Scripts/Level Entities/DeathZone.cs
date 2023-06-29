using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class DeathZone : MonoBehaviour
{

    private Player _playerRef = null;
    [SerializeField] private float _minimumPointY;
    void Start()
    {
        _playerRef = FindObjectOfType<Player>();
        _minimumPointY = transform.position.y;
    }

    void Update()
    {
        if (_playerRef.IsAlive && _playerRef.transform.position.y < _minimumPointY)
        {
            _playerRef.setIsAlive(false);
        }
        
    }
}
