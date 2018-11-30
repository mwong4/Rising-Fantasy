using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCrafting : MonoBehaviour {

	public bool touchingRock;
	public bool touchingWood;

	public bool destroyMaterials;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (touchingWood == true && touchingRock == true) {
			
			//Spawn turret

			destroyMaterials = true;
		} else {
			destroyMaterials = false;
		}
		
	}

	void OnCollisionEnter(Collision collision)
	{
		if ( collision.gameObject.tag == "RawRockResource" || collision.gameObject.tag == "RawRockResourceTwo" || collision.gameObject.tag == "RawRockResourceThree" ) {
			touchingRock = true;

		}
		if ( collision.gameObject.tag != "RawRockResource" && collision.gameObject.tag != "RawRockResourceTwo" && collision.gameObject.tag != "RawRockResourceThree" ) {
			touchingRock = false;

		}
		if ( collision.gameObject.tag == "RefinedWoodResource"  ) {
			touchingWood = true;

		}
		if ( collision.gameObject.tag != "RefinedWoodResource"  ) {
			touchingWood = false;

		}
		if (destroyMaterials == true) {
			Destroy (collider.gameObject);
		}
	} 
}
