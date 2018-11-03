using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proje : MonoBehaviour {
	
	public float speed;
	Rigidbody rb;
	TurretMovement mov;

	// Use this for initialization
	void Start () {
		mov = GameObject.FindGameObjectWithTag ("Player").GetComponent<TurretMovement> ();
		rb = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {

		rb.velocity = new Vector3 (rb.velocity.x, speed / 1/2, rb.velocity.z);



		transform.position = Vector3.MoveTowards (transform.position, mov.endPoint, speed * Time.deltaTime);
		Destroy (gameObject, 1f);

	}
	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Floor") {

			Destroy (gameObject);
		} else {
			Destroy (gameObject, 0.2f);
		}

	} 


}

