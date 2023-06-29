using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    [SerializeField] private Text _scoreText = null;
    void Start()
    {
        _scoreText = GameObject.FindGameObjectWithTag("Score Counter").GetComponent<Text>();

    }

    void Update()
    {
        _scoreText.text = "dsfjkldsjfkdsjfkdsjfk";

    }
}
