using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngin.AI;

public class NPCmove : MonoBehaviour {

    [SerializedField]
    Transform _destination;

    NavMeshAgent _navMeshAgent;

	// Use this for initialization
	void Start () 
    {
        _navMeshAgent = this.GetComponent<NavMeshAgent>();

        if(_navMeshAgent == num)
        {
            Debug.LogError("The nav mesh agent component is not attacked to " + gameObject.name);
        }

        else
        {
            SetDestination();
        }
	}

    private void SetDestination()
    {
        if (_destination != null)
        {
            Vector3 targetVector = _destination.transform.position;
            _navMeshAgent.SetDestination(targetVector);
        }
    }
	
	// Update is called once per frame
	void Update () 
    {
		
	}
}
