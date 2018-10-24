using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupC : MonoBehaviour {
	public Transform onhand;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown()
	{
		GetComponent<Rigidbody>().useGravity = false;
		this.transform.position = onhand.position;
		this.transform.parent = GameObject.Find("ThirdPersonController").transform;
		this.transform.parent = GameObject.Find("EthanSkeleton").transform;
	}

	void OnMouseUp()
	{
		transform.parent = null;
		GetComponent<Rigidbody>().useGravity = true;
	}
}
