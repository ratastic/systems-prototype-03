using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;
using System.Collections;

public class PentacleLogic : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    private float juggleTime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        juggleTime = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        juggleTime += Time.deltaTime;
        UpdateTimerUI();
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("ballBounds"))
        {
            GameOver();
        }
    }

    public void GameOver()
    {

    }
    
    public void UpdateTimerUI()
    {
        int minutes = Mathf.FloorToInt(juggleTime / 60);
        int seconds = Mathf.FloorToInt(juggleTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
