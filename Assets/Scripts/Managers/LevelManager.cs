using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    
    private Coin[] _levelCoins  = null;
    private int _collectedCoins = 0;
    void Start()
    {
        setUpForLevel();
    }
    
    void Update()
    {
        
    }

    private void setUpForLevel()
    {
      _levelCoins = FindObjectsOfType<Coin>();
      _collectedCoins = 0;
      foreach (Coin coin in _levelCoins)
      {
         coin._collectEvent.AddListener( IncreaseScore ); 
      }
    }


    private void IncreaseScore()
    {
        _collectedCoins += 1;
    }

    public int CollectedCoins => _collectedCoins;

}
