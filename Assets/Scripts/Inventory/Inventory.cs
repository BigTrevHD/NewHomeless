using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {
    public gameMaster gm;
    public Slot slotScript;
    public CanvasRayCast canvasCast;


    public List<GameObject> InventorySlots = new List<GameObject>();
    private int allSlots;
    private GameObject[] slot;

    public GameObject slotHolder;

    public bool boughtItem = false;

    public int slotNumb = 0;
  

    //public GameObject Slot1;
    //public GameObject Slot2;
    //public GameObject Slot3;
    //public GameObject Slot4;
    //public GameObject Slot5;

    //public int Slot1Used = 0;
    //public int Slot2Used = 0;
    //public int Slot3Used = 0;
    //public int Slot4Used = 0;
    //public int Slot5Used = 0;


    // Use this for initialization
    void Start () {
        allSlots = 5;
        slot = new GameObject[allSlots];

        for (int i = 0; i < allSlots; i++)
        {
            slot[i] = slotHolder.transform.GetChild(i).gameObject;

            if (slot[i].GetComponent<Slot>().item == null)
                slot[i].GetComponent<Slot>().empty = true;
        }

        //InventorySlots.Add(Slot1);
        //InventorySlots.Add(Slot2);
        //InventorySlots.Add(Slot3);
        //InventorySlots.Add(Slot4);
        //InventorySlots.Add(Slot5);

    }

    public void Update()
    {
        for (int i = 0; i < allSlots; i++)
        {
            slot[i] = slotHolder.transform.GetChild(i).gameObject;

            if (slot[i].GetComponent<Slot>().item == null)
                slot[i].GetComponent<Slot>().empty = true;
        }
        slotNumb = canvasCast.setSlotNumb;
        Debug.Log("This Inventory slot is " +slotNumb);
       
        
    }

    public void BuyItem(float cost)
    {
        
        if (gm.cash >= cost)
        {
            gm.cash -= cost;
            boughtItem = true;
            


        }

    }

    public void AddToInv(GameObject item)
    {
        if(boughtItem)
        {
        for (int i = 0; i < allSlots; i++)
            {
                if(slot[i].GetComponent<Slot>().empty)
                {
                //add item
                slot[i].GetComponent<Slot>().item = item;

                slot[i].GetComponent<Slot>().UpdateSlot();
                slot[i].GetComponent<Slot>().empty = false;
                    boughtItem = false;
                return;
                }

            
        }
        }
        
    }
    public void EmptySlot()
    {
        
        {        
            slot[slotNumb].GetComponent<Slot>().item = null;
            return;

        }
    }

   
}
