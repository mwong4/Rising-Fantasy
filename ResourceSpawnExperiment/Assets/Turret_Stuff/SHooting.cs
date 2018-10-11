using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SHooting : MonoBehaviour {

	public GameObject projectile;

	public Transform shotPoint;

	public float fireRate = 10f;
	private float nextTimeToFire = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Time.time >= nextTimeToFire) {
			Instantiate (projectile, shotPoint.position, shotPoint.rotation);
			nextTimeToFire = Time.time + 1.5f / fireRate;

		}
	}
}
