using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretPlacement : MonoBehaviour {
	
	public float distanceFromPlayer; //variable to hold the distance between player and platform
	public float lockRadius; // min distance to lock position0

	public float currentTime; //variable holding artificial time
	public float delay; //delay that the position is locked

	//variable to hold the players transform
	public Transform myPlayerTransform;

	public bool lockingPosition;
	public bool delayActive;

	public WeaponSwitching myWeaponSwitching;


	// Use this for initialization
	void Start () {

		myWeaponSwitching = GameObject.FindWithTag ("SelectWeapon").GetComponent<WeaponSwitching> ();

		//referencing and setting "myPlayer" as the player's transform
		myPlayerTransform = GameObject.FindWithTag ("Player").transform;

		currentTime = 0;

		lockingPosition = false;
		delayActive = false;
		
	}
	
	// Update is called once per frame
	void Update () {

		//setting "distanceFromPlayer" as the distance between the player and platform transofrm
		distanceFromPlayer = Vector3.Distance (myPlayerTransform.position, transform.position);

		/*Checking to see if the distance is close enough to lock*/
		if (distanceFromPlayer <= lockRadius && lockingPosition == false && myWeaponSwitching.selectedWeapon == 0) {

				lockingPosition = true;//Lock Player onto the platform's transform
				delayActive = true;
				myPlayerTransform.transform.position = new Vector3 (transform.position.x, transform.position.y + 1, transform.position.z);

		}

		if (delayActive == true) {
			currentTime += 0.1f;
			myPlayerTransform.transform.position = new Vector3 (transform.position.x, transform.position.y + 1, transform.position.z);
		}
		if (currentTime >= delay && delayActive == true) {
			delayActive = false;
			currentTime = 0;
		}


		if (distanceFromPlayer >= lockRadius && lockingPosition == true) {
			lockingPosition = false;
		}
		
	}
}
