using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject tapToStart;
    public GameObject scoreText;
    private void Start()
    {
        gameOverPanel.SetActive(false);
        tapToStart.SetActive(true);
        PauseGame();
    }
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            StartGame();
        }
    }
    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        scoreText.SetActive(false );
    }
    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void PauseGame()
    {
        Time.timeScale = 0f;
    }
    public void StartGame()
    {
        tapToStart.SetActive(false);
        Time.timeScale = 1f;
    }


}
