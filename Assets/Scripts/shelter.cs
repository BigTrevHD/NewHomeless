using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shelter : MonoBehaviour {
    public digitalClock clock;
    public gameMaster gm;

    private int startTime;
    private float currentTime;
    private bool queueing = false;

    public Text countdown;
    public Text shelterInfo;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        countdown.text = (currentTime.ToString("00"));
        if(queueing)
        {
            shelterInfo.text = "You are now in the Queue.\n"  +currentTime;
        } else
        {
            shelterInfo.text = "The current wait time is " +startTime +" and a place is not guaranteed";
        }
        
        switch (clock.hour)
        {
            case 20:
                startTime = 120;
                break;
            case 21:
                startTime = 180;
                break;
            case 22:
                startTime = 240;
                break;
            default:
                print("Incorrect intelligence level.");
                break;
        }
    }

    public void Queue()
    {
        currentTime = startTime;
        StartCoroutine("ReduceQueue");
    }

    IEnumerator ReduceQueue()
    {
        
        yield return new WaitForSeconds(0.08333333f);
        currentTime -= 1;
        queueing = true;
        StartCoroutine("ReduceQueue");
    }
}
