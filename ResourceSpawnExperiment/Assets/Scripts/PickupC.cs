using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupC : MonoBehaviour {
	public Transform onhand;

	// Use this for initialization
	void Start () {

       //rigidbody.detectionCollision = false;
        GetComponent<Rigidbody>().useGravity = false;

       // onhand = GameObject.FindGameObjectWithTag("OnHandPosition").position; 

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown()
	{
		GetComponent<Rigidbody>().useGravity = false;
       // rigidbody.detectionCollision = true;
		this.transform.position = onhand.position;
		this.transform.parent = GameObject.FindWithTag("Player").transform;
		this.transform.parent = GameObject.Find("EthanSkeleton").transform;
	}

	void OnMouseUp()
	{
		transform.parent = null;
		GetComponent<Rigidbody>().useGravity = true;
       // rigidbody.detectionCollision = true;
	}
}
