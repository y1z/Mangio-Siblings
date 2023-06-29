using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider2D))]
public class Collectable : MonoBehaviour
{
    private bool is_collected = false;
    private Collider2D _collider;
    public UnityEvent _collectEvent;

    private void Awake()
    {
        _collider = GetComponent<Collider2D>();
    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Player"))
        {
            is_collected = true;
           _collectEvent.Invoke();
           gameObject.SetActive(false); 
        }
    }

    private void OnDisable()
    {
        _collectEvent.RemoveAllListeners();
    }

    public bool IsCollected()
    {
        return is_collected;
    }

}
