﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    public Text timerText, timerScoreText;
    public float timer=0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameControl.isRunning)
        {
            timer += Time.deltaTime;
            int seconds = (int)(timer % 60);
            int minutes = (int)(timer / 60) % 60;

            string timerString = string.Format("{0:00}:{1:00}", minutes, seconds);
            timerText.text = timerString;
            timerScoreText.text = timerString;
            Debug.Log(timer);
        }
    }
}
