using System.Collections;
using UnityEngine;

public class PlayerMotor : MonoBehaviour 
{
	private CharacterController controller;

	private float verticalVelocity;
	private float gravity = 14.0f;
	private float jumpForce = 10.0f;

	private void Start()
	{
		controller = GetComponent<CharacterController> ();
	}

	private void Update()
	{
		if(controller.isGrounded)
		{
			verticalVelocity = -gravity * Time.deltaTime;
			if (Input.GetKeyDown (KeyCode.Space)) 
			{
				verticalVelocity = jumpForce;
			}
		}
		else
		{
			verticalVelocity-= gravity * Time.deltaTime;
		}
	}
}

