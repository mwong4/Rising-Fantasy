using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScript : MonoBehaviour {

	public float speed;
	public float health;
	public float Curhealth;

    public float BulletDamage;

	public Transform target;

	public ParticleSystem enemyDeath;
	public GameObject turnOnBar;
	public Image image;

    public GameObject myPlayer;

	// Use this for initialization
	void Start () {
		enemyDeath.Stop ();
		Curhealth = health;

		target = GameObject.FindGameObjectWithTag ("Tower").GetComponent<Transform> ();
		turnOnBar = GameObject.Find ("HealthBar_Gameobject");
		turnOnBar.SetActive (false);

        myPlayer = GameObject.FindGameObjectWithTag("Player");// Get XP Script and xpPoints value
        PlayerXP playerScript = myPlayer.GetComponent<PlayerXP>();

        BulletDamage = 1f;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.MoveTowards (transform.position, target.position, speed * Time.deltaTime);	

		if (health <= 0) {
			CommitDie ();
		}

        Debug.Log("BulletDamage is :" + BulletDamage);



	}

	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Projectile") {
			
			image.fillAmount = image.fillAmount - BulletDamage / Curhealth;
			health = health - BulletDamage;
			turnOnBar.SetActive (true);
		}
	} 

	void CommitDie (){
        myPlayer.GetComponent<PlayerXP>().CurrentXP += 10f;
        
        //Justin, Right here, you should instantiate the particle effect instead -Max
        enemyDeath.Play();

		Destroy (this.gameObject);
		enemyDeath.transform.position = transform.position;

	}
}
