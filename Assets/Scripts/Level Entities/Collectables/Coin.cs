using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Coin : Collectable
{
    [SerializeField] private int _value = 1;
    public int Value => _value ;
    private UnityEvent _collectEvent;

}
