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

	public Player_Health ph;

	// Use this for initialization
	void Start () {
		respawning = false;

		myMovement = GameObject.FindWithTag ("PlayerPrefab").GetComponent<movement> ();

	}

	// Update is called once per frame
	void Update () {

		if (ph.health <= 0) {
			CommitDeath ();
			DisableMovement();
			respawning = true;

		}

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




		
	

	void CommitDeath() {
		Instantiate (deathP, transform.position, Quaternion.identity);
	}

	void Respawn() {
		transform.position = spawnPoint.position;
	}

	void DisableMovement() {
		myMovement.moveSpeed = 0;
	}

	void EnableMovement() {
		myMovement.moveSpeed = 8;
	}

}

﻿

