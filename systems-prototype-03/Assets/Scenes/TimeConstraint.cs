using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;
using System.Collections;

public class TimeConstraint : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    private float juggleTime;
    public bool timerIsRunning;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        juggleTime = 0f;
        timerIsRunning = true;

    }

    // Update is called once per frame
    void Update()
    {
        juggleTime += Time.deltaTime;
        UpdateTimerUI();
    }

    public void UpdateTimerUI()
    {
        if (timerIsRunning == true)
        {
            int minutes = Mathf.FloorToInt(juggleTime / 60);
            int seconds = Mathf.FloorToInt(juggleTime % 60);
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }
}
