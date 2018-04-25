using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockSound : MonoBehaviour {


	AudioSource clockSound;

	void Awake () {
		clockSound = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision other){
		if (other.gameObject.CompareTag ("Player")) {
			clockSound.Play ();
		}
	}
}
