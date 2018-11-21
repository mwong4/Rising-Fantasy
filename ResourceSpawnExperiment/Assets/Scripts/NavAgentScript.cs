using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavAgentScript : MonoBehaviour {

    public Transform target;
	public GameObject destination;
    NavMeshAgent agent;

	// Use this for initialization
	void Start () 
    {
        agent = GetComponent<NavMeshAgent>();	

//		destination = GameObject.FindWithTag ("Destination")();
//		target = destination.transform;

		Debug.Log (target);
	}
	
	// Update is called once per frame
	void Update () 
    {
		agent.destination = target.position;
	}
}
