using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotatoe : MonoBehaviour {

	public GameObject targetObject;
	private float targetAngle = 0;
	const float rotationAmount = 1.5f;
	public float rDistance = 1.0f;
	public float rSpeed = 1.0f;
	//new rules
	//public Transform target;
	//public float smoothSpeed = 0.125f;
	//public Vector3 offset;

	// Update is called once per frame


	void Update()
	{
		//                 transform.LookAt (targetObject);
		// Trigger functions if Rotate is requested
		if (Input.GetKeyDown(KeyCode.Q)) {
			targetAngle -= 45.0f;
		} else if (Input.GetKeyDown(KeyCode.E)) {
			targetAngle += 45.0f;
		}

		if(targetAngle !=0)
		{
			Rotate();
		}
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