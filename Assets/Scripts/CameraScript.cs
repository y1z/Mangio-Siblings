using System;
using System.Numerics;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;

public class CameraScript : MonoBehaviour
{
    private const float CAMERA_Z_OFFSET = -10F;
    [SerializeField] private PlayerMovement _playerRef;
    [SerializeField] private float _speed = 10.0f;
    [SerializeField] private float _yOffSet = 1.0f;
    
    // controls how far the camera is from the target in the y axis.

    void Start()
    {
        _playerRef = FindObjectOfType< PlayerMovement >();
    }

    // Note this uses Vector3 because Vector2 does not contain the Slerp function
    void LateUpdate()
    {
        Vector3 target_pos = _playerRef.transform.position;
        // the -10f is for keeping the camera from zooming in which causes it to view nothing
        Vector3 new_position = new Vector3(target_pos.x, target_pos.y + _yOffSet, CAMERA_Z_OFFSET);

        transform.position = Vector3.Lerp(transform.position, new_position, _speed * Time.deltaTime);
    }

}