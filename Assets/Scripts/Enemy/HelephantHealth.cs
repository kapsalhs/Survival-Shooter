using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelephantHealth : MonoBehaviour {

	EnemyHealth enemyhealth;
	GameObject[] zombunnies;
	GameObject[] zombears;

	void Awake () {
		enemyhealth = GetComponent<EnemyHealth> ();
	}
	

	void Update () {
		if (enemyhealth.currentHealth <= 0) {
			zombunnies = GameObject.FindGameObjectsWithTag("Zombunny");
			zombears = GameObject.FindGameObjectsWithTag("Zombear");
			foreach (GameObject zombunny in zombunnies) {
				zombunny.GetComponent<EnemyHealth> ().currentHealth = 0;
				zombunny.GetComponent<AudioSource>().volume = 0;
			    zombunny.GetComponent<EnemyHealth> ().Death ();
			}
			foreach (GameObject zombear in zombears) {
				zombear.GetComponent<EnemyHealth> ().currentHealth = 0;
				zombear.GetComponent<AudioSource>().volume = 0;
				zombear.GetComponent<EnemyHealth> ().Death ();

			}
				
		}
	}
}
