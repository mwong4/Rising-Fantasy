using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeRangedOnClick : MonoBehaviour {

    public GameObject myPlayer;
    float xpPoints;
    float rangedLevel;

    // Use this for initialization
    void Start()
    {

        myPlayer = GameObject.FindGameObjectWithTag("Player");// Get XP Script and xpPoints value
        PlayerXP playerScript = myPlayer.GetComponent<PlayerXP>();

        xpPoints = playerScript.CurrentXP;
        rangedLevel = playerScript.RangedLevel;


        // playerScript.CurrentXP = xpPoints;

    }

    // Update is called once per frame
    void Update()


    {

   //     Debug.Log("Referenced points is: " + xpPoints + " and Levels are: " + rangedLevel);

    }

    public void UpgradeRanged()
    {
        if (xpPoints > 7 /*Level Up Requirement*/ && xpPoints)
        {
            xpPoints = xpPoints - 7; //reduce xpPoints by 10
            rangedLevel = rangedLevel + 1f;//level up ranged

            myPlayer.GetComponent<PlayerXP>().RangedLevel += 1f;
            myPlayer.GetComponent<PlayerXP>().CurrentXP -= 7f;

            //      if (playerScript.CurrentXP >= 10 /*Level Up Requirement*/){
            //         playerScript.CurrentXP = CurrentXp - 10f;

            //   Debug.Log("Action");

            // }
        }

    }
}
