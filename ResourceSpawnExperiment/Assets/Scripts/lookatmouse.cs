 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookatmouse : MonoBehaviour {

	Transform lookAt;

	// Use this for initialization
	void Start () {
		lookAt = GameObject.FindGameObjectWithTag("Crosshair").GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (lookAt);
	}
}
