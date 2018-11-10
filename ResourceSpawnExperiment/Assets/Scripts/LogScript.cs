using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogScript : MonoBehaviour {
	
	public Transform onhand;
    public Rigidbody rb;

	//public GameObject myLog;
	
	bool mouseDown = false;


	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody>();

        rb.isKinematic = true;
		rb.detectCollisions = true;
     //   rb.detectCollisions = false;
	 
	 GetComponent<Rigidbody>().useGravity = true;
	 
	 		onhand = GameObject.FindWithTag("OnHandPosition").transform;



	}
	
	// Update is called once per frame
	void Update () {

		if(mouseDown == true){
			this.transform.position = onhand.position;
			//this.transform.parent = GameObject.FindWithTag("Player").transform;
			//this.transform.parent = GameObject.Find("EthanSkeleton").transform;
		}else{
			GetComponent<Rigidbody>().useGravity = true;
		}
		
		
	}
		
		void OnMouseDown()
	{

		GetComponent<Rigidbody>().useGravity = false;
		rb.isKinematic = true;
		//this.transform.position = onhand.position;
		//this.transform.parent = GameObject.FindWithTag("Player").transform;
		//this.transform.parent = GameObject.Find("EthanSkeleton").transform;
		
		mouseDown = true;
	}

    void OnMouseUp()
    {
        transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        // rigidbody.detectionCollision = true;	}
		rb.isKinematic = false;
		mouseDown = false;

    }
		
}
