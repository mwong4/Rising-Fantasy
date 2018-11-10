using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupC : MonoBehaviour {
	public Transform onhand;
    public Rigidbody rb;

	public GameObject myLog;

	// Use this for initialization
	void Start () {


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

		Instantiate(myLog, this.transform.position, Quaternion.identity);
		Destroy(this.gameObject);
	}
}
