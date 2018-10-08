﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public GameObject projectile;
    public Transform shotPoint;
	public bool click;

    Vector3 lookPos;
	public Vector3 endPoint; 

	public float fireRate = 10f;
	private float nextTimeToFire = 0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame 

    void Update()
    {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100))
        {
            lookPos = hit.point;

        }

        Vector3 lookDir = lookPos - transform.position;
        lookDir.y = 0;

        transform.LookAt(transform.position + lookDir, Vector3.up);



		if (Input.GetMouseButton(0) && Time.time >= nextTimeToFire)
        {
			if (Physics.Raycast (ray, out hit)) {
				endPoint = hit.point;
			}

			Instantiate (projectile, shotPoint.position, shotPoint.rotation);
			nextTimeToFire = Time.time + 3f / fireRate;
           
        }

    }

}