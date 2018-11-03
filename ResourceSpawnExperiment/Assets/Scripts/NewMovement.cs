using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMovement : MonoBehaviour {

	public float moveSpeed;

	// Use this for initialization
	void Start () {
		moveSpeed = 7f;
		
	}
	
	// Update is called once per frame
	void Update () {
		//if (Input.GetKey (KeyCode.W)) {
			//Debug.Log("W is working");
	//	}
		transform.Translate (moveSpeed * Input.GetAxis ("Horizontal") * Time.deltaTime, 0f, moveSpeed * Input.GetAxis ("Vertical") * Time.deltaTime);
		
	}
}
