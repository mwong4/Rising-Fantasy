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

		rb.velocity = new Vector3 (rb.velocity.x, 12, rb.velocity.z);

		transform.LookAt (mov.endPoint);

		transform.position = Vector3.MoveTowards (transform.position, mov.endPoint, speed * Time.deltaTime);

	}
	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Floor") {
			mov.canShoot = true;
			Destroy (gameObject);
		} else {
			Destroy (gameObject, 0.2f);
		}

	} 


}

