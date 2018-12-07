using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SHooting : MonoBehaviour {

	public GameObject projectile;

	public Transform shotPoint;

	public Transform box;

	public float currentTime;
	public float delay;

	Transform lookAt;

	public List<GameObject> enemiesInRange = new List<GameObject> ();

	public bool enemyEntered= false;

	// Use this for initialization
	void Start () {
		//lookAt = GameObject.FindGameObjectWithTag("Crosshair").GetComponent<Transform>();
		
	}
	
	// Update is called once per frame
	void Update () {

		//transform.LookAt (lookAt);



		if (enemiesInRange.Count == 0) {

		} else {
			GameObject closest = null;
			float distance = Mathf.Infinity;
			Vector3 position = transform.position;



			foreach (GameObject x in enemiesInRange) {

				if (x == null) {
					enemiesInRange.Remove (x);
					return;
				}

				Vector3 diff = x.transform.position - position;
				float curDistance = diff.sqrMagnitude;
				if (curDistance < distance)
				{
					closest = x;
					distance = curDistance;
				}


			}
			//return closest;

			this.transform.LookAt(closest.transform.position);

		}

		currentTime += 1;


		if (currentTime >= delay) {
			Instantiate (projectile, shotPoint.position, shotPoint.rotation);
			currentTime = 0;
		}
	}

	void OnTriggerEnter(Collider collision)
	{
		if (collision.gameObject.tag == "Enemy") {
			enemyEntered = true;
			enemiesInRange.Add (collision.gameObject);
		}
	}

	void OnTriggerExit(Collider other){
		enemiesInRange.Remove (other.gameObject);
	}
}
