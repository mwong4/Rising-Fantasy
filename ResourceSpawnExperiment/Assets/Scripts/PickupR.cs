using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupR : MonoBehaviour {

	public Transform onhand;
	public Rigidbody rb;

	// Use this for initialization
	void Start () {

		onhand = GameObject.FindWithTag("OnHandPosition").transform;


		GetComponent<Rigidbody>().useGravity = false;
		rb = GetComponent<Rigidbody>();

		rb.isKinematic = false;
		rb.detectCollisions = true;
		//   rb.detectCollisions = false;



	}

	// Update is called once per frame
	void Update () {

	}

	void OnMouseDown()
	{

		rb.isKinematic = true;
		rb.detectCollisions = true;

		GetComponent<Rigidbody>().useGravity = false;

		this.transform.position = onhand.position;
		this.transform.parent = GameObject.FindWithTag("Player").transform;
		this.transform.parent = GameObject.Find("EthanSkeleton").transform;
	}

	void OnMouseUp()
	{
		transform.parent = null;
		GetComponent<Rigidbody>().useGravity = true;
		// rigidbody.detectionCollision = true;	}

		rb.isKinematic = false;
		rb.detectCollisions = true;
	}
}
