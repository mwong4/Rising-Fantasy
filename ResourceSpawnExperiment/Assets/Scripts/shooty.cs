using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooty : MonoBehaviour {

    public float speed;

	Movement mov;

	// Use this for initialization
	void Start () {
		mov = GameObject.FindGameObjectWithTag ("Player").GetComponent<Movement> ();
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.MoveTowards (transform.position, mov.endPoint, speed * Time.deltaTime);
		Destroy (gameObject, 1f);
	
	}
	void OnCollisionEnter(Collision collision)
	{

			Destroy (gameObject, 0.3f);
	} 
}

