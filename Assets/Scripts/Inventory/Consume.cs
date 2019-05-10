using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consume : MonoBehaviour {
    public float addHunger = 0;
    public float addThirst = 0;
    public float addWarmth = 0;

    public playerStats stats;
    public Inventory inv;
    public sounds sounds;

    // Use this for initialization
    void Start () {
        stats = GameObject.FindGameObjectWithTag("gm").GetComponent<playerStats>();
        inv = GameObject.FindGameObjectWithTag("gm").GetComponent<Inventory>();
        sounds = GameObject.FindGameObjectWithTag("Player").GetComponent<sounds>();

    }
	
	// Update is called once per frame
	public void UseItem (float soundNum)
    {
        Destroy(gameObject);
        inv.EmptySlot();
        stats.Hunger += addHunger;
        stats.Thirst += addThirst;
        stats.Warmth += addWarmth;

        if (soundNum == 1)
        {
            sounds._as.clip = sounds.audioClipArray[1];
        }
        if (soundNum == 2)
        {
            sounds._as.clip = sounds.audioClipArray[2];
        }
       
        sounds.PlaySound();
    }
}
