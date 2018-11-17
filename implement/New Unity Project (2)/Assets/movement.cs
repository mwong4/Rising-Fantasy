using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

	public bool moving;



		void Start ()
	{

		moving = true;
		}

		void Update ()
		{

		if (moving == true) {
				var x = Input.GetAxis ("Horizontal") * Time.deltaTime * 150.0f;
				var z = Input.GetAxis ("Vertical") * Time.deltaTime * 5.0f;

				transform.Rotate (0, x, 0);
				transform.Translate (0, 0, z);
			}
		}
	
	}
