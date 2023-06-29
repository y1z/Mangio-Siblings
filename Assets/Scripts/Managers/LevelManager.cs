using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    
    private Coin[] _levelCoins  = null;
    private int _collectedCoins = 0;
    void Start()
    {
      _levelCoins = FindObjectsOfType<Coin>();
    }
    
    void Update()
    {
        
    }
}
