using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScript : MonoBehaviour {

	public float speed;
	public float health;
	private float fHealth;
    public float BulletDamage;

	public GameObject enemyDeath;
	public GameObject turnOnBar;
	public Image image;

	public NewXPSystem myNewXpSystem;


	//variables for the XP system
	GameObject myPlayer; //referenced script
	public float xpGained; //experienced gained each time an enemy dies


	// Use this for initialization
	void Start () {
		fHealth = health;
		turnOnBar = GameObject.Find ("HealthBar_Gameobject");
		turnOnBar.SetActive (false);

        //myPlayer = GameObject.FindGameObjectWithTag("Player");// Get XP Script and xpPoints value
        //PlayerXP playerScript = myPlayer.GetComponent<PlayerXP>();

		//referencing the newPlayerXpScript
		myNewXpSystem = GameObject.FindWithTag ("Player").GetComponent<NewXPSystem> ();

	}
	
	// Update is called once per frame
	void Update () {

		image.fillAmount = health / fHealth;

		if (health <= 0) {
			CommitDie ();
		}
	}

	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Projectile") {

			//if the enemy is shot, increase XP for ranged
			//myNewXpSystem.currentRangedXp += xpGained;

			health = health - BulletDamage;

			turnOnBar.SetActive (true);


		}
	} 

	void CommitDie (){
        //myPlayer.GetComponent<PlayerXP>().CurrentXP += 10f;
        
        //Justin, Right here, you should instantiate the particle effect instead -Max



		Destroy (this.gameObject);
		Instantiate (enemyDeath, transform.position, Quaternion.identity);

	}
}
