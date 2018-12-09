using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Health : MonoBehaviour {

	public float health;
	public Image image;

	public bool hit;

	//Current UI text
	public Text myHealthText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		myHealthText.text = "Health  " + ((health / 5) * 100) + "%";

		image.fillAmount = health / 5;

		Debug.Log (health/5);
	}

	void OnCollisionEnter (Collision col){
		if (col.gameObject.tag == "Enemy") {
			health = health - 1;
			hit = true;

		}
	}

	void OnCollisionExit (Collision col){
		if (col.gameObject.tag == "Enemy") {
			hit = false;
		}
	}
}
