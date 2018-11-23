using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

	public float moveSpeed;

	Player_Health ph;
	Rigidbody rb;

	private CamShake shake;

	// Use this for initialization
	void Start () {
		ph = GetComponentInChildren<Player_Health> ();
		rb = GetComponent<Rigidbody> ();
		shake = GameObject.FindGameObjectWithTag ("ScreenShake").GetComponent<CamShake> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (ph.hit == true) {
			shake.CamShake_ ();

			moveSpeed = -16;
			StartCoroutine (Wait ());
			} 


		transform.Translate(moveSpeed*Input.GetAxis("Horizontal")*Time.deltaTime,0f,moveSpeed*Input.GetAxis("Vertical") * Time.deltaTime);
	}
	IEnumerator Wait()
	{
		
		yield return new WaitForSeconds (1);
		moveSpeed = 8;

	}
}
