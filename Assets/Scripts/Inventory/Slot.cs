using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour {
    public Inventory inv;

    public bool empty = true;
    public GameObject item;

    public int slotNumb;
    
	

    public void UpdateSlot()
    {
        GameObject myItem = Instantiate(item, new Vector3(0,0,0), Quaternion.identity) as GameObject;
        myItem.transform.SetParent(transform, false);
    }

    private void OnMouseOver()
    {
        inv.slotNumb = slotNumb;
    }
}
