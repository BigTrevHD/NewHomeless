using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interact : MonoBehaviour {

    public Text itemText;

	// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update ()
    {                      
           
            RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 2))
        {
            itemText.text = "" + hit.collider.gameObject.name;
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
          //  Debug.Log("Object: " + hit.collider.gameObject.name);
        } 
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 2, Color.red);
            itemText.text = "";


        }
        

    }
}
