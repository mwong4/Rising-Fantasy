using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupR : MonoBehaviour {

	public Transform onhand;
	public Rigidbody rb;

	//referencing scripts
	public WeaponSwitching myWeaponSwitching;
	public TimeSystem myPhases;

	public bool pickedUp = false;

	// Use this for initialization
	void Start () {

		onhand = GameObject.FindWithTag("OnHandPosition").transform;


		GetComponent<Rigidbody>().useGravity = true;
		rb = GetComponent<Rigidbody>();

		rb.isKinematic = false;
		rb.detectCollisions = true;
		//   rb.detectCollisions = false;

		//referencing the phase
		myPhases = GameObject.FindWithTag ("Phases").GetComponent<TimeSystem> ();
		//referencing the weapon selected
		myWeaponSwitching = GameObject.FindWithTag ("SelectWeapon").GetComponent<WeaponSwitching> ();



	}

	// Update is called once per frame
	void Update () {

		if (pickedUp == true) {
			this.transform.position = onhand.position;
		}

	}

	void OnMouseDown()
	{
		if((myPhases.CurrentPhase == 1 && myWeaponSwitching.selectedWeapon == 0) || (myPhases.CurrentPhase == 2 && myWeaponSwitching.selectedWeapon == 0)){

		rb.isKinematic = true;
		rb.detectCollisions = true;

		GetComponent<Rigidbody>().useGravity = false;

		this.transform.position = onhand.position;
		this.transform.parent = GameObject.FindWithTag("Player").transform;
		//this.transform.parent = GameObject.Find("EthanSkeleton").transform;

			pickedUp = true;
		}
	}

	void OnMouseUp()
	{
		transform.parent = null;
		GetComponent<Rigidbody>().useGravity = true;
		// rigidbody.detectionCollision = true;	}

		rb.isKinematic = false;
		rb.detectCollisions = true;

		pickedUp = false;


	}
}
