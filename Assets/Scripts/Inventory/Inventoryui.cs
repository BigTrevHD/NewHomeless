using UnityEngine;

public class InventoryUI : MonoBehaviour {
    private bool showInv;
    public GameObject Inventory;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            showInv = !showInv;
        }

        if (showInv)
        {
            Inventory.GetComponent<Renderer>().enabled = !GetComponent<Renderer>().enabled;

        }
        //else
        //{
        //    Inventory.SetActive(false);          
            
        //}
    }
}
