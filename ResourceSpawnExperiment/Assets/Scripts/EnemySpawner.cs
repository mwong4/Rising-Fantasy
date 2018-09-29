using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

	public GameObject Enemy;

	public GameObject SpawnPoint;

	int SpawnCount;
	public int SpawnLimit;

	public float CurrentTime;
	public float SetDelay;



	// Use this for initialization
	void Start () {

		SpawnPoint = GameObject.FindGameObjectWithTag ("SpawnPoint");
		
	}
	
	// Update is called once per frame
	void Update () {

		if (SpawnCount < SpawnLimit && CurrentTime < SetDelay)
		{
			CurrentTime += 0.01f;
		}
		if (SpawnCount < SpawnLimit && CurrentTime > SetDelay)
		{
			CurrentTime = 0f;
			Instantiate(Enemy, SpawnPoint.transform.position, Quaternion.identity);
		}

		//Debug.Log("ResourceObjects: " + ResourceCount);

		SpawnCount = GameObject.FindGameObjectsWithTag("Enemy").Length;

		
	}
}
