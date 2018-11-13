using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupC : MonoBehaviour {
	public Transform onhand;
    public Rigidbody rb;

	public GameObject myLog;

	//referencing scripts
	public WeaponSwitching myWeaponSwitching;
	public TimeSystem myPhases;

	// Use this for initialization
	void Start () {
		
		//referencing the phase
		myPhases = GameObject.FindWithTag ("Phases").GetComponent<TimeSystem> ();
		//referencing the weapon selected
		myWeaponSwitching = GameObject.FindWithTag ("SelectWeapon").GetComponent<WeaponSwitching> ();


        GetComponent<Rigidbody>().useGravity = true;
		
		//onhand = GameObject.FindWithTag("OnHandPosition");

        rb = GetComponent<Rigidbody>();


	//myLog = GameObject.FindWithTag ("RefinedWoodResource");

        rb.isKinematic = true;
		rb.detectCollisions = true;
     //   rb.detectCollisions = false;



	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown()
	{
		if (myPhases.CurrentPhase == 1 && myWeaponSwitching.selectedWeapon == 0 || myPhases.CurrentPhase == 2 && myWeaponSwitching.selectedWeapon == 0) {

			Instantiate (myLog, this.transform.position, Quaternion.identity);
			Destroy (this.gameObject);
		}
	}
}
