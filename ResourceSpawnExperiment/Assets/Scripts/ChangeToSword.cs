using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeToSword : MonoBehaviour {

	int m_IndexNumber;

	public GameObject weaponSelect;

	// Use this for initialization
	void Start () {

		//Find weaon selector
		weaponSelect = GameObject.FindWithTag ("SelectWeapon");

		//set parent to weapon selector
		this.gameObject.transform.parent = weaponSelect.transform;

		//Set position to 3
		m_IndexNumber = 2;
		transform.SetSiblingIndex (m_IndexNumber);
		
	}

	// Update is called once per frame
	void Update () {




		
	}
}
