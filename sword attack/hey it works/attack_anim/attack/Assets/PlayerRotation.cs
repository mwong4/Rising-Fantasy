using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{


	Vector3 lookPos;
	public Vector3 endPoint; 



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


	}

}
