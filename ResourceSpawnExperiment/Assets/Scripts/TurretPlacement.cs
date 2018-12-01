using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretPlacement : MonoBehaviour {
	
	public float distanceFromResourceOne; //variable to hold the distance between Resource and platform
	public float distanceFromResourceTwo; //variable to hold the distance between Resource and platform
	public float distanceFromResourceThree; //variable to hold the distance between Resource and platform
	public float distanceFromResourceFour; //variable to hold the distance between Resource and platform

	public float lockRadius; // min distance to lock position

	//public float currentTime; //variable holding artificial time
	//public float delay; //delay that the position is locked

	//variable to hold the resources transform
	public Transform myResourceTransform;
	public Transform mySecondResourceTransform;
	public Transform myThirdResourceTransform;
	public Transform myFourthResourceTransform;

	//public bool lockingPosition;
	//public bool delayActive;

	public TimeSystem myTimeSystem;


	// Use this for initialization
	void Start () {

		myTimeSystem = GameObject.FindWithTag ("Phases").GetComponent<TimeSystem> ();

		//referencing and setting "myPlayer" as the player's transform
		//myResourceTransform = GameObject.FindWithTag ("RefinedWoodResource").transform;
		//mySecondResourceTransform = GameObject.FindWithTag ("RawRockResource").transform;
		//myThirdResourceTransform = GameObject.FindWithTag ("RawRockResourceTwo").transform;
		//myFourthResourceTransform = GameObject.FindWithTag ("RawRockResourceThree").transform;


		//currentTime = 0;

		//lockingPosition = false;
		//delayActive = false;
		
	}
	
	// Update is called once per frame
	void Update () {

		//Asigning the distance
		distanceFromResourceOne = Vector3.Distance (myResourceTransform.position, transform.position);
		distanceFromResourceTwo = Vector3.Distance (mySecondResourceTransform.position, transform.position);
		distanceFromResourceThree = Vector3.Distance (myThirdResourceTransform.position, transform.position);
		distanceFromResourceFour = Vector3.Distance (myFourthResourceTransform.position, transform.position);

		if (distanceFromResourceOne >= lockRadius && myTimeSystem.CurrentPhase <= 3) {
			
			myResourceTransform.transform.position = new Vector3 (transform.position.x, transform.position.y + 1, transform.position.z);

		}

		if (distanceFromResourceTwo >= lockRadius && myTimeSystem.CurrentPhase <= 3) {

			mySecondResourceTransform.transform.position = new Vector3 (transform.position.x, transform.position.y + 1, transform.position.z);

		}

		if (distanceFromResourceThree >= lockRadius && myTimeSystem.CurrentPhase <= 3) {

			myThirdResourceTransform.transform.position = new Vector3 (transform.position.x, transform.position.y + 1, transform.position.z);

		}

		if (distanceFromResourceFour >= lockRadius && myTimeSystem.CurrentPhase <= 3) {

			myFourthResourceTransform.transform.position = new Vector3 (transform.position.x, transform.position.y + 1, transform.position.z);

		}
		
	}
}
