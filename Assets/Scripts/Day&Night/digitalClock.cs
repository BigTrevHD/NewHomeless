using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class digitalClock : MonoBehaviour {
    private bool nightTime;
    public gameMaster gm;

    public Text clockText;

    
    public int hour = 010;
    public int minute = 0;

    private GameObject[] streetlights;

   

	// Use this for initialization
	void Start () {
        // Calls the updateClock function, waits for x seconds, calls it every x seconds (12th of a day in minutes)

        InvokeRepeating("UpdateClock", 0f, gm.timeSpeed);
        streetlights = GameObject.FindGameObjectsWithTag("streetlight");
        
        
    }

    void Update()
    {
        //Switches nightTime boolean on/off depending on time
        if (hour == 20)
        {
            nightTime = true; 
        }
        if(hour == 4)
        {
            nightTime = false;
        }

        if (nightTime)
        {
            for (int i = 0; i < streetlights.Length; i++)
            {
                streetlights[i].SetActive(true);
            }
        }
        else
        {
            for (int i = 0; i < streetlights.Length; i++)
            {
                streetlights[i].SetActive(false);
            }

        }

        clockText.text = (hour.ToString("00")) +":" +(minute.ToString("00"));

        if (minute >= 60)
        {
            hour++;
            minute = 0;
        }
        if (hour >= 24)
        {
            hour = 0;
            gm.day++;
        }
    }

    void UpdateClock()
    {
        if (!gm.showDiary)
        {
            minute++;
        }
        
    }
}
