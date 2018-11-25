using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

	public float moveSpeed;

	Player_Health ph;


	// Use this for initialization
	void Start () {
		ph = GetComponentInChildren<Player_Health> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (ph.hit == true) {

			moveSpeed = -8;
			StartCoroutine (Wait ());
			} 


		transform.Translate(moveSpeed*Input.GetAxis("Horizontal")*Time.deltaTime,0f,moveSpeed*Input.GetAxis("Vertical") * Time.deltaTime);
	}
	IEnumerator Wait()
	{
		
		yield return new WaitForSeconds (0.3f);
		moveSpeed = 8;

	}
}
