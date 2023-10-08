using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text scoreText;
    public Text timerText;
    public GameObject gameOverPanel;
    void Start()
    {
    }
    public void UpdateScore(int score)
    {
        scoreText.text = "Score: " + score.ToString();
    }
    public void UpdateTimer(float time)
    {
        timerText.text = "Time: " + time.ToString("F1"); 
    }
    public void ShowGameOverPanel()
    {
        gameOverPanel.SetActive(true);
    }
}
