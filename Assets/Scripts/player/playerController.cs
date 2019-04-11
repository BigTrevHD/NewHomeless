using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

    float speed = 3;
    float rotSpeed = 9;
    private float rotDir = 0f;
    float gravity = -1;

    private bool rotating = false;

    Vector3 moveDir = Vector3.zero;

    CharacterController controller;
    Animator anim;

    // Use this for initialization
    void Start()
    {
       // transform.position = new Vector3(PlayerPrefs.GetFloat("X"), PlayerPrefs.GetFloat("Y"), PlayerPrefs.GetFloat("Z"));
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        if (controller.isGrounded)
        {
            if (Input.GetKey(KeyCode.W))
            {
                anim.SetFloat("speed", 1);
                moveDir = new Vector3(0, 0, 1);
                moveDir *= speed;
                rotDir = 0;
                rotating = true;
            }


            if (Input.GetKeyUp(KeyCode.W))
            {
                anim.SetFloat("speed", 0);
                moveDir = new Vector3(0, 0, 0);
            }

            if (Input.GetKey(KeyCode.A))
            {
                anim.SetFloat("speed", 1);
                moveDir = new Vector3(-1, 0, 0);
                moveDir *= speed;
                rotDir = -90;
                rotating = true;
            }
            if (Input.GetKeyUp(KeyCode.A))
            {
                moveDir = new Vector3(0, 0, 0);
                anim.SetFloat("speed", 0);
            }
            if (Input.GetKey(KeyCode.S))
            {
                anim.SetFloat("speed", 1);
                moveDir = new Vector3(0, 0, -1);
                moveDir *= speed;
                rotDir = 180;
                rotating = true;
            }
            if (Input.GetKeyUp(KeyCode.S))
            {
                moveDir = new Vector3(0, 0, 0);
                anim.SetFloat("speed", 0);
            }

            if (Input.GetKey(KeyCode.D))
            {
                anim.SetFloat("speed", 1);
                moveDir = new Vector3(1, 0, 0);
                moveDir *= speed;
                rotDir = 90;
                rotating = true;
            }
            if (Input.GetKeyUp(KeyCode.D))
            {
                moveDir = new Vector3(0, 0, 0);
                anim.SetFloat("speed", 0);
            }
        }




        if (rotating)
        {
            Vector3 direction = new Vector3(transform.rotation.eulerAngles.x, rotDir, transform.rotation.eulerAngles.z);
            Quaternion targetRotation = Quaternion.Euler(direction);
            this.transform.rotation = Quaternion.Lerp(this.transform.rotation, targetRotation, Time.deltaTime * rotSpeed);
        }



        //Debug.Log("rotation direction " + rotDir);
        //  Debug.Log(rotating);
        moveDir.y -= gravity * Time.deltaTime;
        controller.Move(moveDir * Time.deltaTime);
    }
}


        
	

