using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeMeleeOnClick : MonoBehaviour {

    public GameObject myPlayer;
    public GameObject myEnemy;
    float xpPoints;
    float meleeLevel;



	// Use this for initialization
	void Start () {

        myPlayer = GameObject.FindGameObjectWithTag("Player");// Get XP Script and xpPoints value
        PlayerXP playerScript = myPlayer.GetComponent<PlayerXP>();

        xpPoints = playerScript.CurrentXP;
        meleeLevel = playerScript.MeleeLevel;

        myEnemy = GameObject.FindGameObjectWithTag("Enemy");//find enemy + enemy script
        EnemyScript enemyScript = myEnemy.GetComponent<EnemyScript>();



       // playerScript.CurrentXP = xpPoints;

	}
	
	// Update is called once per frame
	void Update () {




      //  Debug.Log("Referenced points is: " + xpPoints + " and Melee Level is: " + meleeLevel);
		
	}

    public void UpgradeMelee()
    {
            if (xpPoints >= 10 /*Level Up Requirement*/){
               xpPoints = xpPoints - 10; //reduce xpPoints by 10
            meleeLevel = meleeLevel + 1f;//level up melee

            myPlayer.GetComponent<PlayerXP>().MeleeLevel += 1f;
            myPlayer.GetComponent<PlayerXP>().CurrentXP -= 10f;

            myEnemy.GetComponent<EnemyScript>().BulletDamage += 1f;

          //  playerScript.CurrentXP = xpPoints;
          //  playerScript.MeleeLevel = meleeLevel;


           // playerScript.MeleeLevel = - 10f;

        //      if (playerScript.CurrentXP >= 10 /*Level Up Requirement*/){
        //         playerScript.CurrentXP = CurrentXp - 10f;

     //   Debug.Log("Action");

   // }
        }

    }
}
