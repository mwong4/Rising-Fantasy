using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceSpawnScript : MonoBehaviour {

    public GameObject Resource;

    //private int rescued;

    //int player;



	// Use this for initialization
	void Start () {

        //player = GameObject.FindGameObjectWithTag("ResourceObject").Length;
		
	}
	
	// Update is called once per frame
	void Update () {




        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(Resource, new Vector3(1, 1, 1), Quaternion.identity);
        }


		
	}
}
