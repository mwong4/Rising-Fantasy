using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewXPSystem : MonoBehaviour {

	//current upgradable level
	public float rangedLevel;
	public float meleeLevel;

	//current experience level
	public float currentRangedXp;
	public float currentMeleeXp;

	public bool upgrade = false;

	//setting the variables for the experience bar
	public GameObject experienceBar;
	public Image image;

	public EnemyScript myEnemyScript;

	//Current UI text
	public Text myXPRangedText;

	public GameObject sword;

	public GameObject newSword;

	public Transform weaponSwitch;


	// Use this for initialization
	void Start () {

		//setting everything to it's default values
		rangedLevel = 1f;
		meleeLevel = 1f;
		currentRangedXp = 0;
		currentMeleeXp = 0;

		experienceBar = GameObject.FindWithTag ("ExperienceBar");

		myEnemyScript = GameObject.FindWithTag ("Enemy").GetComponent<EnemyScript> ();

		//sword = GameObject.FindWithTag("LogWeapon");

		//weaponSwitch = GameObject.FindWithTag ("SelectWeapon").transform;

		//image.fillAmount = 0;

		image.fillAmount = 0;
		
	}
	
	// Update is called once per frame
	void Update () {

		myXPRangedText.text = "Ranged Level: " + (rangedLevel);

		image.fillAmount = (currentRangedXp/100);


	/*	if(Input.GetKey("space"))
		{
			currentRangedXp+=0.01f;
		}*/

//		Debug.Log (currentRangedXp);

		//image.fillAmount = currentRangedXp/100;

		if (currentRangedXp >= 100 ) {
			currentRangedXp = currentRangedXp - 100f;
			rangedLevel = rangedLevel + 1;
			myEnemyScript.BulletDamage += 1;
		}

		if (currentMeleeXp >= 100 ) {
			currentMeleeXp = currentMeleeXp - 100f;
			meleeLevel = meleeLevel + 1;
		}

		if (rangedLevel == 2 && upgrade == false) {
			upgrade = true;
			Destroy (sword);
			Instantiate (newSword, weaponSwitch.position, weaponSwitch.rotation);
		}
		
	}
}
