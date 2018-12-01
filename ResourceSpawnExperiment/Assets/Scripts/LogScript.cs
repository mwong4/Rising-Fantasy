using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogScript : MonoBehaviour {
	
	public Transform onhand;
    public Rigidbody rb;

	//referencing scripts
	public WeaponSwitching myWeaponSwitching;
	public TimeSystem myPhases;

	//public GameObject myLog;
	
	bool mouseDown = false;

	public NewCrafting myNewCrafting;


	// Use this for initialization
	void Start () {

		myNewCrafting = GameObject.FindGameObjectWithTag ("Platform").GetComponent<NewCrafting> ();

		//referencing the phase
		myPhases = GameObject.FindWithTag ("Phases").GetComponent<TimeSystem> ();
		//referencing the weapon selected
		myWeaponSwitching = GameObject.FindWithTag ("SelectWeapon").GetComponent<WeaponSwitching> ();

        rb = GetComponent<Rigidbody>();

        rb.isKinematic = true;
		rb.detectCollisions = true;
     //   rb.detectCollisions = false;
	 
	 GetComponent<Rigidbody>().useGravity = true;
	 
	 		onhand = GameObject.FindWithTag("OnHandPosition").transform;



	}
	
	// Update is called once per frame
	void Update () {

		if(mouseDown == true){
			this.transform.position = onhand.position;
			//this.transform.parent = GameObject.FindWithTag("Player").transform;
			//this.transform.parent = GameObject.Find("EthanSkeleton").transform;
		}else{
			GetComponent<Rigidbody>().useGravity = true;
		}
		
		
	}
		
		void OnMouseDown()
	{
		if (myPhases.CurrentPhase == 1 && myWeaponSwitching.selectedWeapon == 0 || myPhases.CurrentPhase == 2 && myWeaponSwitching.selectedWeapon == 0) {

			GetComponent<Rigidbody> ().useGravity = false;
			rb.isKinematic = true;
			//this.transform.position = onhand.position;
			//this.transform.parent = GameObject.FindWithTag("Player").transform;
			//this.transform.parent = GameObject.Find("EthanSkeleton").transform;
		
			mouseDown = true;
		}
	}

    void OnMouseUp()
    {
        transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        // rigidbody.detectionCollision = true;	}
		rb.isKinematic = false;
		mouseDown = false;

    }

	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Platform") {
			myNewCrafting.touchingWood = true;
				myNewCrafting.craftMaterials.Add (this.gameObject);

		} else {
			myNewCrafting.touchingWood = false;
		}
	}
		
}
