using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotatoe : MonoBehaviour {

	public GameObject targetObject;
	private float targetAngle = 0;
	const float rotationAmount = 1.5f;
	public float rDistance = 1.0f;
	public float rSpeed = 1.0f;
	public Transform target;
	public float smoothSpeed = 0.125f;
	Vector3 offset;
	int currIndex = 0;
	// Update is called once per frame

	public Vector3[] offsets;


	void Start()
	{
		offsets = new Vector3[4];

		offsets[0] = new Vector3 (0, 16, -4);
		offsets[1] = new Vector3 (4, 16, 0);
		offsets[2] = new Vector3 (0, 16, 4);
		offsets[3] = new Vector3 (-4, 16, 0);

		offset = offsets [0];
	

	}
	void Update()
	{
		
		//                 transform.LookAt (targetObject);
		// Trigger functions if Rotate is requested
		if (Input.GetKeyDown(KeyCode.Q)) {
			targetAngle -= 90.0f;

			currIndex++;
			if (currIndex > 3)
				currIndex = 0;


		
		}

		if (Input.GetKeyDown(KeyCode.E)) {
			targetAngle += 90.0f;

			currIndex--;
			if (currIndex < 0)
				currIndex = 3;
		
		}

		offset = offsets [currIndex];
		if(targetAngle !=0)
		{
			
			//Rotate();
		}
		transform.position = target.position + offset;
		this.transform.LookAt (target);
	}

	protected void Rotate()
	{

		float step = rSpeed * Time.deltaTime;
		float orbitCircumfrance = 2F * rDistance * Mathf.PI;
		float distanceDegrees = (rSpeed / orbitCircumfrance) * 360;
		float distanceRadians = (rSpeed / orbitCircumfrance) * 2 * Mathf.PI;

		if (targetAngle>0)
		{
			transform.RotateAround(targetObject.transform.position, Vector3.up, -rotationAmount);

			transform.RotateAround(Vector3.zero, Vector3.up, 20 * Time.deltaTime);
			targetAngle -= rotationAmount;
		}
		else if(targetAngle <0)
		{
			transform.RotateAround(targetObject.transform.position, Vector3.up, rotationAmount);
			targetAngle += rotationAmount;
		}

	}
}



//link...
//https://answers.unity.com/questions/655896/rotating-a-camera-90-degrees-around-an-object.html