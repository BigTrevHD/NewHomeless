using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AISpawn : MonoBehaviour {
    public Transform spawner;

    public GameObject SpawnThisAI;
    public GameObject AIType1;
    public GameObject AIType2;
    public GameObject AIType3;

    private float spawnRateMin = 2;
    private float spawnRateMax = 10;

    private int chooser;
    

    // Use this for initialization
    void Start () {
        InvokeRepeating("SpawnAI", 1.0f, Random.Range(spawnRateMin,spawnRateMax));
    }
	
	// Update is called once per frame
	void SpawnAI() {
        chooser = Random.Range(1, 3);

        if(chooser == 1)
        {
            SpawnThisAI = AIType1;
        }
        if (chooser == 2)
        {
            SpawnThisAI = AIType2;
        }
        if (chooser == 3)
        {
            SpawnThisAI = AIType3;
        }
        GameObject AI = Instantiate(SpawnThisAI, new Vector3(spawner.position.x, spawner.position.y, spawner.position.z), Quaternion.identity) as GameObject;
    }
}
