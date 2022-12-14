using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;
    //public GameObject[] targets;

    private float spawnRate = 1.0f;

    private int score;
    private int scoreMax;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI scoreMaxText;
    public TextMeshProUGUI gameOverText;

    public Button restartButton;

    public GameObject titleScreen;

    public bool isGameActive;

    void Start()
    {
        scoreMax = PlayerPrefs.GetInt("score");
        if(PlayerPrefs.GetInt("score") > PlayerPrefs.GetInt("scoreMax"))
        {
            PlayerPrefs.SetInt("scoreMax", scoreMax);
        }

        //Debug.Log(PlayerPrefs.GetInt("score"));
    }   

    void Update()    {    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "        : " + score;
        scoreMaxText.text = "record: " + PlayerPrefs.GetInt("scoreMax");

        PlayerPrefs.SetInt("score", score);
    }
    IEnumerator SpawnTarget()
    {
        while (isGameActive)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        }
    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);

        isGameActive = false;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void StartGame(int difficulty)
    {
        isGameActive = true;
        score = 0;

        //spawnRate = spawnRate / difficulty;
        spawnRate /= difficulty;

        StartCoroutine(SpawnTarget());
        UpdateScore(0);

        titleScreen.gameObject.SetActive(false);
    }
}
