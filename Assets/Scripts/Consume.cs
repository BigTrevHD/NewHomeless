using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consume : MonoBehaviour {
    public float addHunger = 0;
    public float addThirst = 0;
    public float addWarmth = 0;

    public playerStats stats;
    public Inventory inv;

    // Use this for initialization
    void Start () {
        stats = GameObject.FindGameObjectWithTag("gm").GetComponent<playerStats>();
        inv = GameObject.FindGameObjectWithTag("gm").GetComponent<Inventory>();

    }
	
	// Update is called once per frame
	public void UseItem ()
    {
        Destroy(gameObject);
        inv.EmptySlot();
        stats.Hunger += addHunger;
        stats.Thirst += addThirst;
        stats.Warmth += addWarmth;

        
    }
}
