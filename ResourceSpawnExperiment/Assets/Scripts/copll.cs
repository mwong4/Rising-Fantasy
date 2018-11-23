using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class copll : MonoBehaviour {

	public GameObject deathP;

	public Transform spawnPoint;

	public float currentTime;
	public float delay;

	public bool respawning;

	public movement myMovement;


	// Use this for initialization
	void Start () {
		respawning = false;

		myMovement = GameObject.FindWithTag ("PlayerPrefab").GetComponent<movement> ();

	}

	// Update is called once per frame
	void Update () {

		if (respawning == true) {
			currentTime += 1;

			if (currentTime >= delay) {
				Respawn();
				EnableMovement ();
				currentTime = 0;
				respawning = false;
			}
		}

	}

	void OnCollisionEnter (Collision col){
		if (col.gameObject.tag == "Enemy") {
			CommitDeath ();
			DisableMovement();
			respawning = true;

		}
	}

	void CommitDeath() {
		Instantiate (deathP, transform.position, Quaternion.identity);
	}

	void Respawn() {
		transform.position = spawnPoint.position;
	}

	void DisableMovement() {
		myMovement.moving = false;
	}

	void EnableMovement() {
		myMovement.moving = true;
	}

}

﻿

