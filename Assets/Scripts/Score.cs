using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI finalScoreText;
    private float score = 0; 
    private bool isGameOver = false;

    void Update()
    {
        if (!isGameOver)
        {
            score += 2 * Time.deltaTime;
            scoreText.text = "Score: " + Mathf.FloorToInt(score);
        }
        finalScoreText.text="Score: " + Mathf.FloorToInt(score).ToString();
    }
    public void GameOver()
    {
        isGameOver = true;
    }
}
