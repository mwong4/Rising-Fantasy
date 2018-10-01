using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingScript : MonoBehaviour {

    //public GameObject Object(#);

    public GameObject Object1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision col)
    {

        if(col.gameObject.tag == "")
        {
            Instantiate(Object1, this.transform.position, Quaternion.identity);
            Destroy(col.GameObject);
            Destroy(this.GameObject);
        }
    }
}
