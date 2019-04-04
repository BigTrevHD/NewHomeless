using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sleep : MonoBehaviour {
    public gameMaster gm;
    public digitalClock clock;
    private bool speedTime;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(clock.hour == 00)
        {
            //Creates a black screen to cover the game screen
            //Triggers the boolean to make the clock speed up
            speedTime = true;
            ForcedSleep();           
        }
        if (clock.hour == 8)
        {
            gm.timeModifier = 1f;
        }

    }

    void ForcedSleep()
    {
        if (speedTime)
        {
           // gm.timeModifier = 3f;
            speedTime = false;
        }
        
    }
}
