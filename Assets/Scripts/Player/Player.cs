using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerMovement _playerMovement;

    private bool is_alive = true;
    
    void Start()
    {
        _playerMovement = GetComponent<PlayerMovement>();
        is_alive = true;
    }


    public void setIsAlive(bool value)
    {
        is_alive = value;
    }

    public bool IsAlive => is_alive;


}
