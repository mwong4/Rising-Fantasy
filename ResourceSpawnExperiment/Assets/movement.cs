﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

	public float speed;

	Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		float horizontal = Input.GetAxis ("Horizontal");
		float verticle = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (horizontal, 0, verticle);

		rb.AddForce (movement * speed / Time.deltaTime );
	}
}
