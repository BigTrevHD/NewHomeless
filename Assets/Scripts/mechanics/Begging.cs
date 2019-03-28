using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Begging : MonoBehaviour {
    private GameObject currNPC;
        
    private int selectedNum = 0;

    //Other Scripts
    private GiveChance chance;
    public gameMaster gm;

    

	// Use this for initialization
	void Start () {
        selectedNum = Random.Range(50, 100);
        


        //GameObject.FindGameObjectsWithTag("NPC");
    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log(currNPC);
        Debug.Log("Selected Number: " + selectedNum);
        chance = currNPC.GetComponent<GiveChance>();
        
	}

    void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("NPC"))
        {            
            if(Input.GetKeyDown(KeyCode.E))
            {
                
                if(selectedNum > chance.giveChance && selectedNum < 100)
                {
                    gm.cash += chance.giveAmount;
                    chance.giveChance = 0;
                    chance.giveAmount = 0;
                    print("Heres some cash bro");
                } else
                {
                    print("yeet");
                }
            }
            currNPC = other.gameObject;
            
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("NPC"))
        {
            currNPC = null;
            
        }
    }

    

}
