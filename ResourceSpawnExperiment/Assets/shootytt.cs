using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootytt : MonoBehaviour {

	public float speed;

	Vector3 direction;

	// Use this for initialization
	void Start () {
		Destroy (gameObject, 1f);s
		direction = this.transform.localPosition;
	}
	
	// Update is called once per frame
	void Update () {
		//this.transform.position = new Vector3 (direction.x, direction.y + speed, direction.z);

		transform.Translate (0, -speed * Time.deltaTime, 0);

	
	}
}
