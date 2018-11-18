using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavAgentScript : MonoBehaviour {

    public Transform target;
    NavMeshAgent agent;

	// Use this for initialization
	void Start () 
    {
        agent = GetComponent<NavMeshAgent>();	

		//target = GameObject.FindWithTag ("Destination").Transform ();
	}
	
	// Update is called once per frame
	void Update () 
    {
		agent.destination = target.position;
	}
}
