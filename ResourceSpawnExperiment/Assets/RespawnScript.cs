using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnScript : MonoBehaviour {

	Player_Health ph;

	movement mov;

	public GameObject deathP;
	public GameObject player;

	Transform plat;

	// Use this for initialization
	void Start () {
		ph = GameObject.FindGameObjectWithTag ("Graphic").GetComponent<Player_Health> ();
		plat = GameObject.Find ("Platform").GetComponent<Transform> ();
		mov = GameObject.FindGameObjectWithTag ("PlayerPrefab").GetComponent<movement> ();
	}
	
	// Update is called once per frame
		void Update () {
		if (ph.health <= 0) {

			Instantiate (deathP, transform.position, Quaternion.identity);
			StartCoroutine (Wait ());
			ph.health = 5;

		}
	}

	IEnumerator Wait()
	{
		player.SetActive (false);
		yield return new WaitForSeconds (0.3f);
		player.SetActive (true);
		ph.hit = false;
		player.transform.position = plat.transform.position + Vector3.up * 10 - Vector3.forward * 4;

	}


}
