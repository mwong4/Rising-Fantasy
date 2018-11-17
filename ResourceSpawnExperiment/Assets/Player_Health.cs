using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Health : MonoBehaviour {

	public float playerHealth;
	public Transform spawnPoint;

	public Image image;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		image.fillAmount = playerHealth / 5;

		if (playerHealth <= 0) {
			transform.position = spawnPoint.position;
		}
	}

	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == "Enemy")
		{
			Debug.Log ("hit");
			playerHealth = playerHealth - 1;


		}
	}
}
