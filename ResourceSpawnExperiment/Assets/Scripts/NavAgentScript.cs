﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavAgentScript : MonoBehaviour {

    public Transform target;
    NavMeshAgent agent = null;


	// Use this for initialization
	void Start () 
    {
        agent = GetComponent<NavMeshAgent>();

		target = GameObject.FindGameObjectWithTag ("Destination").transform;
	}
	
	// Update is called once per frame
	void Update () 
    {
        agent.SetDestination(target.position);
	}
}
