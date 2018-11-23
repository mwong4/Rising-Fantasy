using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Health : MonoBehaviour {

	public float health;
	public Image image;

	public bool hit;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		image.fillAmount = health / 5;
	}

	void OnCollisionEnter (Collision col){
		if (col.gameObject.tag == "Enemy") {
			hit = true;
			health = health - 1;
		}
	}

	void OnCollisionExit (Collision col){
		if (col.gameObject.tag == "Enemy") {
			hit = false;
		}
	}
}
