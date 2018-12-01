using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCrafting : MonoBehaviour {

	public bool touchingRock;
	public bool touchingWood;


	public List<GameObject> craftMaterials = new List<GameObject> ();

	public GameObject turretPrefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (touchingWood == true && touchingRock == true) {

			//spawning the turret
			Instantiate(turretPrefab, new Vector3( transform.position.x, transform.position.y + 2, transform.position.z), Quaternion.identity);

			foreach (GameObject x in craftMaterials) {
				Destroy (x);
			}

			touchingWood = false;
			touchingRock = false;
		}
		
	}

	void OnCollisionEnter(Collision collision)
	{
		if ( collision.gameObject.tag == "RawRockResource" || collision.gameObject.tag == "RawRockResourceTwo" || collision.gameObject.tag == "RawRockResourceThree" ) {
			touchingRock = true;
			craftMaterials.Add (collision.gameObject);

		}
		else {
			touchingRock = false;

		}
			
	} 
}
