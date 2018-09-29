using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SHooting : MonoBehaviour {

	public GameObject projectile;

	public Transform shotPoint;

	public Transform box;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		Instantiate (projectile, shotPoint.position, shotPoint.rotation);	
	}
}
