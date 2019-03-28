using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour {
    public Camera cam;
    public Transform mainCam;
    public Transform cafeCam;

    // Use this for initialization
    void Start () {
		cam = GetComponent<Camera>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
