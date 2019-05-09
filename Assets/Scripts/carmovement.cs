using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carmovement : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(speed * -Time.deltaTime, 0f, 0f);
       // transform.Rotate(0, 90, 0);
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("rotator"))
        {
            Destroy(gameObject);
        }
    }
    


}


