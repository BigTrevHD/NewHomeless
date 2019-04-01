using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavAI : MonoBehaviour
{

    private float speed = 1f;

    Animator anim;


    public GameObject[] moveSpots;
    private int randomSpot;


    // Use this for initialization
    void Start()
    {
        moveSpots = GameObject.FindGameObjectsWithTag("Destination");
        anim = GetComponent<Animator>();
        randomSpot = Random.Range(0, moveSpots.Length);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, moveSpots[randomSpot].transform.position, speed * Time.deltaTime);
        transform.LookAt(moveSpots[randomSpot].transform);
        anim.SetFloat("speed", 1);

        if(transform.position == moveSpots[randomSpot].transform.position)
        {
            Destroy(gameObject);
        }
    }
}

    
