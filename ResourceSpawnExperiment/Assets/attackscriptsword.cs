using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour{

	Animator animator;
	WeaponSwitching wp;

	// Use this for initialization
	void Start () 
	{
		wp = GetComponent<WeaponSwitching> ();
		animator = GetComponent<Animator> ();
	}



	public void PerformAttack()
	{
		animator.SetTrigger("Base_Attack");
	}

	// Update is called once per frame
	void Update () 

	{
		if(Input.GetMouseButtonDown(0))
		{

			if(wp.selectedWeapon == 1)

			{
				PerformAttack ();
			}
		}

	}
}