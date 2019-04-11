using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rummage : MonoBehaviour
{
    public int chance;
    public float amount;
    private bool showBin;
    public GameObject binInv;
    public gameMaster gm;

    // Use this for initialization
    void Start()
    {
        
    }

    void Update()
    {
        if (showBin)
        {
            binInv.SetActive(true);

        }
        else
        {
            binInv.SetActive(false);
        }
            

        }
        void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Bin"))
            {
            
            if (Input.GetKeyDown(KeyCode.E))
                 {
                amount = Random.Range(0f, 2f);
                chance = Random.Range(61, 100);
                if (chance > 60)
                    {
                        gm.cash += amount;
                        amount = 0;

                }
            }
        }
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bin"))
        {
            showBin = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Bin"))
        {
            showBin = false;
        }
    }
}
