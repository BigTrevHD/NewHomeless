using System.Collections;
using System;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class gameMaster : MonoBehaviour {
    public GameObject player;
    public GameObject lastPos;
    
    public bool showDiary;
    public GameObject Diary;
        
    public Text cashText; 

    public float cash;
    //Camera Control
    public Camera cam;
    public Transform mainCam;
    public Transform cafeCam;
    public Transform shelterCam;

    //Scene switch
    public int currentScene;

    //Inventory
    public Inventory inv;

    //time & day
    [HideInInspector]
    public int dayCount = 1;
    private string day;
    public Text dayText;
    public float timeSpeed = 0.083333333f;
    public float timeModifier = 1;

   // public Dialog dialog;


    // Use this for initialization
    void Start () {
        
    	}
	
	// Update is called once per frame
	void Update () {
        WhatDay();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            showDiary = !showDiary;
        }

        if (showDiary)
        {
            Diary.SetActive(true);
            timeSpeed = 0f;
            Time.timeScale = 0f;

         //dialog.StartType();
        }

        else
        {
            Diary.SetActive(false);
            timeSpeed = 0.083333333f;
            Time.timeScale = 1f * timeModifier;
        }
        cashText.text = "£" + cash.ToString("F2");
        dayText.text = "" + day;

        

    }

    public void PlayerisSwitching()
    {
        //PlayerPrefs.SetFloat("X", lastPos.transform.position.x);
        //PlayerPrefs.SetFloat("Y", lastPos.transform.position.y);
        //PlayerPrefs.SetFloat("Z", lastPos.transform.position.z);
        // Player Switches Scene

    }
    public void WhatDay()
    {
        switch (dayCount)
        {
            case 1:
                day = "Monday";
                    break;
            case 2:
                day = "Tuesday";
                break;
            case 3:
                day = "Wednesday";
                break;
            case 4:
                day = "Thursday";
                break;
            case 5:
                day = "Friday";
                break;
            default:
                break;
        }

    }


 
    }

