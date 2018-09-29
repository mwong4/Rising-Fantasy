using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingInstantiation : MonoBehaviour {

    public GameObject Object;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        if(Input.GetButtonDown("Fire1")){
            Debug.Log("Fired");
            Instantiate(Object, new Vector3(1, 1, 1), Quaternion.identity);
        }
		
	}
}
