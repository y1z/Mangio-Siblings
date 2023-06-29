using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Collider2D))]
public class LevelEndPoint : MonoBehaviour
{
    private const string DEFAULT_LEVEL_NAME = "StartScreenScene";
    [SerializeField] private string _nextLevelToLoad;

    private void Awake()
    {
        if (_nextLevelToLoad == "")
        {
            _nextLevelToLoad = DEFAULT_LEVEL_NAME;
            print("_nextLevelToLoad was not set, so using default level instead");
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            SceneManager.LoadScene(_nextLevelToLoad);
        }
        
    }
}
