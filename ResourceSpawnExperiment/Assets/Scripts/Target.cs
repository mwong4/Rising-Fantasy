using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {

	Vector3 loc;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Vector3 p = Input.mousePosition;
		//p.z = 20;
	//	Vector3 pos = Camera.main.ScreenToWorldPoint (p);
	
	//	gameObject.transform.position = pos;


		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;



		if (Physics.Raycast(ray, out hit))
		{
			//if (!hit.transform.gameObject.CompareTag ("StupidWalls")) {
				loc = hit.point;
			//}
		}
		transform.position = loc;
		//transform.position = new Vector3 (loc.x,loc.y+0.6f,loc.z);
		transform.position = new Vector3 (transform.position.x,loc.y+0.6f, transform.position.z);
		
	}
}
