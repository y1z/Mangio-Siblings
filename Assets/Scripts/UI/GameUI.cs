using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    [SerializeField] private Text _scoreText = null;
    [SerializeField] private Text _gameOverText= null;
    [SerializeField] private LevelManager _levelManager = null;
    [SerializeField] private Player _playerRef = null;
    void Start()
    {
        _scoreText = GameObject.FindGameObjectWithTag("Score Counter").GetComponent<Text>();
        _gameOverText = GameObject.FindGameObjectWithTag("Game Over").GetComponent<Text>();
        _levelManager = FindObjectOfType<LevelManager>();
        _playerRef = FindObjectOfType<Player>();

        _gameOverText.gameObject.SetActive(false);
    }

    void Update()
    {
        UpdateScore();

        if (!_playerRef.IsAlive)
        {
            _gameOverText.gameObject.SetActive(true);
        }
    }

    void UpdateScore()
    {
        _scoreText.text = "Score " + _levelManager.CollectedCoins;
    }
}
