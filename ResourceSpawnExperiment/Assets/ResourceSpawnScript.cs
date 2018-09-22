using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public float LimitCounter;
    preivate int ResourceCounter;

    public GameObject ResourceObject;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if(GameObject.FindGameObjectWithTag("ResourceObjects").Length < LimitCounter) {
            Instantiate(ResourceObject, newVector3(0, 0, 0), Quaternion.identity);
        }
		
	}
}
