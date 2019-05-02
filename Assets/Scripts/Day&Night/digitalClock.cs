using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class digitalClock : MonoBehaviour {
    public bool nightTime;
    public gameMaster gm;

    public Text clockText;


    
    public int hour = 10;
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
        //Turns the street lights on when its night time
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
        //Changes the hour when the minute reaches 60
        if (minute >= 60)
        {
            hour++;
            minute = 0;
        }
        //Changes the day when the hour reaches 24 and displays 00 instead of 24 for authenticity
        if (hour >= 24)
        {
            hour = 0;
            gm.dayCount++;
        }

        //Kicks the player out of any establishment at x time
        if(hour == 23)
        {
            gm.currentScene = 0;
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
