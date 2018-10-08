using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {

	public float speed;
	public float health;
	public float Curhealth;

	public Transform target;

	public ParticleSystem enemyDeath;
	public GameObject turnOnBar;
	public Image image;

	// Use this for initialization
	void Start () {
		enemyDeath.Stop ();
		Curhealth = health;

		target = GameObject.FindGameObjectWithTag ("Tower").GetComponent<Transform> ();
		turnOnBar = GameObject.Find ("HealthBar_Gameobject");
		turnOnBar.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.MoveTowards (transform.position, target.position, speed * Time.deltaTime);	

		if (health <= 0) {
			CommitDie ();
		}




	}

	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Projectile") {
			
			image.fillAmount = image.fillAmount - 1 / Curhealth;
			health = health - 1;
			turnOnBar.SetActive (true);
		}
	} 

	void CommitDie (){
		Destroy (gameObject);
		enemyDeath.transform.position = transform.position;
		enemyDeath.Play ();
	}
}
