using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animSpeed : MonoBehaviour {
    public gameMaster gm;

    Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        anim.SetFloat("runSpeed", gm.timeModifier);
	}
}
