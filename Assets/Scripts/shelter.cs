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

    private int successNum;
    private int playerNum;

    public Text countdown;
    public Text shelterInfo;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        countdown.text = (currentTime.ToString("00"));
        //if(queueing)
        //{
        //    shelterInfo.text = "You are now in the Queue.\n"  +currentTime;
        //} else
        {
            shelterInfo.text = "Due to the rise in homelessness, the shelter is currently full. We are waiting for government expansion. Sorry for the inconvience caused.";
        }
        
        switch (clock.hour)
        {
            case 20:
                startTime = Random.Range(60, 120);
                break;
            case 21:
                startTime = Random.Range(120, 180);
                break;
            case 22:
                startTime = Random.Range(180, 240);
                break;
            default:
                print("");
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
        if (currentTime <= 0)
        {
            currentTime = 0;
            
        }
        
    }

}
