using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewbJump : MonoBehaviour {

	public float fallMultiplier = 2.5f;
	public float lowjumpMultiplier = 2f;

	Rigidbody rb;

	void Awake(){
		rb = GetComponent<Rigidbody> ();
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (rb.velocity.y < 0) {
			rb.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
		} else if (rb.velocity.y > 0 && !Input.GetButton ("Jump")) {
			rb.velocity += Vector3.up * Physics.gravity.y * (lowjumpMultiplier - 1) * Time.deltaTime;
		}
		
	}
}
