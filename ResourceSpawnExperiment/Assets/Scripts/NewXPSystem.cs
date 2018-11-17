using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewXPSystem : MonoBehaviour {

	//current upgradable level
	public float rangedLevel;
	public float meleeLevel;

	//current experience level
	public float currentRangedXp;
	public float currentMeleeXp;

	//setting the variables for the experience bar
	public GameObject experienceBar;
	public Image image;


	// Use this for initialization
	void Start () {

		//setting everything to it's default values
		rangedLevel = 1f;
		meleeLevel = 1f;
		currentRangedXp = 0;
		currentMeleeXp = 0;

		experienceBar = GameObject.FindWithTag ("ExperienceBar_Gameobject");
		
	}
	
	// Update is called once per frame
	void Update () {

		image.fillAmount = image.fillAmount*( currentRangedXp / 10 );

		if (currentRangedXp >= 100 ) {
			currentRangedXp = currentRangedXp - 100f;
			rangedLevel = rangedLevel + 1;
		}

		if (currentMeleeXp >= 100 ) {
			currentMeleeXp = currentMeleeXp - 100f;
			meleeLevel = meleeLevel + 1;
		}
		
	}
}
