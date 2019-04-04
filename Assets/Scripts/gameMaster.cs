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
    public float day = 1;
    public Text dayText;
    public float timeSpeed = 0.083333333f;
    public float timeModifier = 1;




    // Use this for initialization
    void Start () {
        cash = 25.50f;
    	}
	
	// Update is called once per frame
	void Update () {
        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            showDiary = !showDiary;
        }

        if (showDiary)
        {
            Diary.SetActive(true);
            timeSpeed = 0f;
            Time.timeScale = 0f;
        }
        else
        {
            Diary.SetActive(false);
            timeSpeed = 0.083333333f;
            Time.timeScale = 1f * timeModifier;
        }
        cashText.text = "£" + cash.ToString();
        dayText.text = "Day: " + day;

        

    }

    public void PlayerisSwitching()
    {
        //PlayerPrefs.SetFloat("X", lastPos.transform.position.x);
        //PlayerPrefs.SetFloat("Y", lastPos.transform.position.y);
        //PlayerPrefs.SetFloat("Z", lastPos.transform.position.z);
        // Player Switches Scene

    }
    public void PlayerIsComingBack()
    {
        // Player comes back
        
    }

 
    }

