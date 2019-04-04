using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shelter : MonoBehaviour {
    public digitalClock clock;
    public gameMaster gm;

    private int startTime;

    private int queueTime;
    private int timeSinceWait;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void Queue()
    {
        startTime = clock.hour;
        InvokeRepeating("ReduceQueue", 0f, gm.timeSpeed);
    }

    void ReduceQueue()
    {

    }
}
