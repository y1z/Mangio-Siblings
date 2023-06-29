using System;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{

    private static GameManager _instance;

    public static GameManager Instance
    {
        get
        {
            if(_instance == null)
                Debug.LogError("Game Manager is null");

            return _instance;
        }
        
    }

    private void Awake()
    {
        _instance = this;
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
           RestartGame(); 
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("StartScreenScene");
    }
}
