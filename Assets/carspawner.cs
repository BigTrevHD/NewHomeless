using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carspawner : MonoBehaviour {

    public GameObject SpawnThisAI;
    public GameObject AIType1;
    public GameObject AIType2;

    public float spawnRateMin = 2;
    public float spawnRateMax = 10;

    public float spawnX;
    public float spawnY;
    public float spawnZ;

    public float angleY;

    private int chooser;

	// Use this for initialization
	void Start () {
        InvokeRepeating("SpawnAI", 1.0f, Random.Range(spawnRateMin, spawnRateMax));


	}
	
	// Update is called once per frame
	void SpawnAI () {
        chooser = Random.Range(1, 2);

        if(chooser == 1)
        {
            SpawnThisAI = AIType1;
        }
        if(chooser == 2)
        {
            SpawnThisAI = AIType2;
        }
        GameObject AI = Instantiate(SpawnThisAI, new Vector3(spawnX, spawnY, spawnZ), transform.rotation) as GameObject;
	}
}
