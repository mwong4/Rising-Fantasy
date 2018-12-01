using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SHooting : MonoBehaviour {

	public GameObject projectile;

	public Transform shotPoint;

	public Transform box;

	public float currentTime;
	public float delay;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		currentTime += 1;


		if (currentTime >= delay) {
			Instantiate (projectile, shotPoint.position, shotPoint.rotation);
			currentTime = 0;
		}
	}
}
