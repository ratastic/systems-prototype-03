using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.SceneManagement;

public class PentacleLogic : MonoBehaviour
{
    public TimeConstraint tc;
    public WandLogic wl;
    public GameObject scoreCanvas;
    public TextMeshProUGUI scoreTime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("ball01") || col.gameObject.CompareTag("ball02"))
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        tc.timerIsRunning = false;
        wl.canCast = false;
        DisplayScore();
    }

    public void DisplayScore()
    {
        scoreCanvas.SetActive(true);

        int minutes = Mathf.FloorToInt(tc.juggleTime / 60);
        int seconds = Mathf.FloorToInt(tc.juggleTime % 60);
        scoreTime.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
