using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proje : MonoBehaviour {

	float currTime;
	public float despawn;

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

		if (mov.canShoot == false) {
			currTime += 1;

			if (currTime >= despawn) {
				currTime = 0;
				mov.canShoot = true;
				Destroy (gameObject);
			}

		}

		rb.velocity = new Vector3 (rb.velocity.x, 12, rb.velocity.z);

		transform.LookAt (mov.endPoint);

		transform.position = Vector3.MoveTowards (transform.position, mov.endPoint, speed * Time.deltaTime);

	}
	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "floor") {
			currTime = 0;
			mov.canShoot = true;
			Destroy (gameObject);
		} 
		if (collision.gameObject.tag == "Enemy") {
			currTime = 0;
			mov.canShoot = true;
			Destroy (gameObject);
		} 

		if (collision.gameObject.tag == "Crosshair") {
			currTime = 0;
			mov.canShoot = true;
			Destroy (gameObject);
		} 

		else {
			Destroy (gameObject, 0.2f);
		}

	} 


}

