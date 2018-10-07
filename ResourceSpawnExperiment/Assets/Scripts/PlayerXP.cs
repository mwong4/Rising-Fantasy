using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerXP : MonoBehaviour {

    public float CurrentXP;
    public float MeleeLevel;
    public float RangedLevel;

	// Use this for initialization
	void Start () {

        CurrentXP = 100f;
        MeleeLevel = 0f;
        RangedLevel = 0f;
		
	}
	
	// Update is called once per frame
	void Update () {

             Debug.Log("Referenced points is: " + CurrentXP + " and Levels are: " + MeleeLevel + "  " + RangedLevel);

 //       Debug.Log("XP level" + CurrentXP);
		
	}
}
