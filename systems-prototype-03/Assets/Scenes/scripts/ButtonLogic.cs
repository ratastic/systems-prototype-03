using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;
using System.Collections;

public class ButtonLogic : MonoBehaviour
{
    public GameObject startCanvas;
    public WandLogic wandLogic;
    public Rigidbody2D rb1;
    public Rigidbody2D rb2;
    public TextMeshProUGUI countdownText;
    public TimeConstraint timeConstraint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startCanvas.SetActive(true);
        rb1.gravityScale = 0;
        rb2.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CloseInstructions()
    {
        startCanvas.SetActive(false);
        StartCoroutine(StartCountdown());
    }

    private IEnumerator StartCountdown()
    {
        int countdownTime = 3;
        while (countdownTime > 0)
        {
            countdownText.text = countdownTime.ToString(); // updates countdown numbers
            yield return new WaitForSeconds(1f);
            countdownTime--;
        }
        
        countdownText.gameObject.SetActive(false);
        TimeToPlay();
    }

    public void TimeToPlay()
    {
        timeConstraint.timerIsRunning = true;
        wandLogic.canCast = true;
        rb1.gravityScale = 1;
        rb2.gravityScale = 1;
    }

}
