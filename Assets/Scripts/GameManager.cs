using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool isGameActive;
    private int score;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI winText;
    public Button restartButton;
    public Button menuButton;
    // Start is called before the first frame update
    void Start()
    {
    gameOverText.gameObject.SetActive(false);
    restartButton.gameObject.SetActive(false);
    menuButton.gameObject.SetActive(false);
    winText.gameObject.SetActive(false);


       UpdateScore(0);
       isGameActive = true;
       
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    public void StartGameEasy()
    {
        SceneManager.LoadScene("DemoScene");
    }

    public void StartGameHard()
    {
        SceneManager.LoadScene("HardScene");
    }

    void GameOver()
    {
        isGameActive = false;
        restartButton.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(true);
        menuButton.gameObject.SetActive(true);


        score = 0;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void WinGame()
    {
        isGameActive = false;
        restartButton.gameObject.SetActive(true);
        menuButton.gameObject.SetActive(true);
        winText.gameObject.SetActive(true);
        score = 0;
    }

    public void UpdateScore(int scoreToAdd){

        score+= scoreToAdd;
        scoreText.text = "Score: " +score;
        if(score == 10)
        {
        WinGame();
        }
    }
}

