using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;
using System.Collections;

public class PentacleLogic : MonoBehaviour
{
    public TimeConstraint tc;
    public WandLogic wl;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
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
    }
}
