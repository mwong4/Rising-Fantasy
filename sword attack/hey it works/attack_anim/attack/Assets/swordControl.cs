using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordControl : MonoBehaviour {

	public Animator anim;

	public KeyCode attack1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (attack1))
			anim.SetTrigger ("swordattack");
		
		
	}
}
