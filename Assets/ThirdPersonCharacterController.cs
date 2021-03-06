﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ThirdPersonCharacterController : MonoBehaviour {
    float speed = 4;
    float rotSpeed = 80;
    float rot = 0f;
    float gravity = 8;

    Vector3 moveDir = Vector3.zero;

    CharacterController controller;
    Animator anim;

    public sounds sounds; 
      

    void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
        sounds = GameObject.FindGameObjectWithTag("Player").GetComponent<sounds>();

    }

    void Update()
    {
        if(controller.isGrounded)
        {
            if (Input.GetKey(KeyCode.W) || (Input.GetKey(KeyCode.UpArrow)))
            {
                anim.SetFloat("speed", 1);
                moveDir = new Vector3(0, 0, 1);
                moveDir *= speed;
                moveDir = transform.TransformDirection(moveDir);
            }
            if(Input.GetKeyUp(KeyCode.W) || (Input.GetKeyUp(KeyCode.UpArrow)))
            {
                anim.SetFloat("speed", 0);
                moveDir = new Vector3(0, 0, 0);
            }
            if (Input.GetKey(KeyCode.S) || (Input.GetKey(KeyCode.DownArrow)))
            {
                anim.SetFloat("speed", 1);
                moveDir = new Vector3(0, 0, -1);
                moveDir *= speed;
                moveDir = transform.TransformDirection(moveDir);
            }
            if (Input.GetKeyUp(KeyCode.S) || (Input.GetKeyUp(KeyCode.DownArrow)))
            {
                anim.SetFloat("speed", 0);
                moveDir = new Vector3(0, 0, 0);
            }
        }
        rot += Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        transform.eulerAngles = new Vector3(0, rot, 0);

        moveDir.y -= gravity * Time.deltaTime;
        controller.Move(moveDir * Time.deltaTime);
    }

    public void Die ()
    {
        sounds._as.clip = sounds.audioClipArray[4];
        
        sounds.PlaySound();
        StartCoroutine("DieSound");
        anim.SetInteger("health", 0);

        StartCoroutine("Restart");
    }
    IEnumerator Restart()
    {

        yield return new WaitForSeconds(6);
        SceneManager.LoadScene(0);

    }
}
