using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

	public float moveSpeed;

	public bool moving;

	// Use this for initialization
	void Start () {
		moving = true;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (moving == true) {
			transform.Translate (moveSpeed * Input.GetAxis ("Horizontal") * Time.deltaTime, 0f, moveSpeed * Input.GetAxis ("Vertical") * Time.deltaTime);
		}
	}
}
