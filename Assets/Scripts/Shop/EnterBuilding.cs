using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterBuilding : MonoBehaviour {
    public int goToScene;
    

    public gameMaster immortal;
    


    private float speed = 2f;


    
    void OnTriggerEnter (Collider other)
    {
        if(other.CompareTag("Player"))
        {

            //SceneManager.LoadScene(goToScene);
            immortal.currentScene = goToScene;
            immortal.PlayerisSwitching();
        }
        
    }
	
	// Update is called once per frame
	void Update () {
        // Sets currentScene based on buildIndex
        // currentScene = SceneManager.GetActiveScene().buildIndex;

        //if (immortal.currentScene == 0)
        //{
        //   immortal.cam.GetComponent<LookAt>().enabled = true;
        //}
        //else
        //{
        //    immortal.cam.GetComponent<LookAt>().enabled = false;
        //}
        if (immortal.currentScene == 0)
        {
            immortal.cam.transform.position = new Vector3(immortal.mainCam.transform.position.x, immortal.mainCam.transform.position.y, immortal.mainCam.transform.position.z);
            immortal.cam.transform.rotation = immortal.mainCam.transform.rotation;
            immortal.cam.fieldOfView = 40;
            //  Debug.Log("Position: " + PlayerPrefs.GetFloat("X") + PlayerPrefs.GetFloat("Y") + PlayerPrefs.GetFloat("Z"));
        }
        if (immortal.currentScene == 1)
        {
            immortal.cam.transform.position = new Vector3(immortal.cafeCam.transform.position.x, immortal.cafeCam.transform.position.y, immortal.cafeCam.transform.position.z);
            immortal.cam.transform.rotation = immortal.cafeCam.transform.rotation;
            immortal.cam.fieldOfView = 60;
        }
        if (immortal.currentScene == 2)
        {
            immortal.cam.transform.position = new Vector3(immortal.shelterCam.transform.position.x, immortal.shelterCam.transform.position.y, immortal.shelterCam.transform.position.z);
            immortal.cam.transform.rotation = immortal.shelterCam.transform.rotation;
            immortal.cam.fieldOfView = 60;
        }





    }

    void OnMouseDown ()
    {
        if (immortal.currentScene != 0)
        {
           immortal.currentScene = goToScene;
            //SceneManager.LoadScene(0);
            //immortal.PlayerIsComingBack();

        }
    }
}
