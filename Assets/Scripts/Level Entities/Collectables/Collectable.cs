using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEditor.UI;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Collectable : MonoBehaviour
{
    private bool is_collected = false;
    private Collider2D _collider;

    private void Awake()
    {
        _collider = GetComponent<Collider2D>();
    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Player"))
        {
            is_collected = true;
            
           print("Player entered collectable");
           gameObject.SetActive(false); 
        }
        
    }

    public bool IsCollected()
    {
        return is_collected;
    }

}
