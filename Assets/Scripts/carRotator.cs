using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carRotator : MonoBehaviour {
  
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        transform.Rotate(0, 90, 0);
    }
}

