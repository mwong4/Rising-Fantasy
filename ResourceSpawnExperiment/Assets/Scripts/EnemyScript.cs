using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScript : MonoBehaviour {

	public float speed;
	public float health;
	private float curHealth;
    public float BulletDamage;

	public GameObject enemyDeath;
	public GameObject turnOnBar;
	public Image image;

	GameObject myPlayer;


	// Use this for initialization
	void Start () {
		curHealth = health;
		turnOnBar = GameObject.Find ("HealthBar_Gameobject");
		turnOnBar.SetActive (false);

        myPlayer = GameObject.FindGameObjectWithTag("Player");// Get XP Script and xpPoints value
        PlayerXP playerScript = myPlayer.GetComponent<PlayerXP>();

	}
	
	// Update is called once per frame
	void Update () {

		if (health <= 0) {
			CommitDie ();
		}
	}

	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Projectile") {

			health = health - BulletDamage;
			
			image.fillAmount = image.fillAmount - BulletDamage / 10;

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
