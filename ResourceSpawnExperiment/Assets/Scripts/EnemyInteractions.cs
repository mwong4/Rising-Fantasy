using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInteractions : MonoBehaviour {

    public float currentTime;
    public float setDelay;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log("Time is:" + currentTime);
    }

    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "Structure" && currentTime < setDelay){
            currentTime += 1f;

        }

        if (col.gameObject.tag == "Structure" && currentTime > setDelay - 1)
        {

            Destroy(col.gameObject);
        }

        if (col.gameObject.tag == "Structure" && currentTime > setDelay)
        {
            currentTime = 0f;

        }

        if (col.gameObject.tag == "Crystal"){
            //End game
            Debug.Log("End Game");

        }
        if (col.gameObject.tag == "Player")
        {
            //Hurt Player
            Debug.Log("Hurt Player");

        }

    }
}
