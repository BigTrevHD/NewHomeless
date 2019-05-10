using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sounds : MonoBehaviour {

    public AudioSource _as;
    public AudioClip[] audioClipArray;

    void Awake()
    {
        _as = GetComponent<AudioSource>();
    }

    // Use this for initialization
    void Start () {

        
       
    }
	
	// Update is called once per frame
	public void PlaySound () {
        _as.PlayOneShot(_as.clip);
    }
}
