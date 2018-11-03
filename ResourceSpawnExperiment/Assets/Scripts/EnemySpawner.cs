using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

	public GameObject Enemy;

	public int ResourceCount;
	public int ResourceLimit;
	//public float rangeSeperation;
	float RandomValue;

	public float CurrentTime;
	public float SetDelay;

	public float RandomSpawnRange;

	//Min spawn range

	public float SpawnRangeMinX;
	public float SpawnRangeMinZ;

	//Max spawn range

	public float SpawnRangeMaxX;
	public float SpawnRangeMaxZ;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		RandomValue = Random.Range (0, RandomSpawnRange);

		if (ResourceCount < ResourceLimit && CurrentTime < SetDelay)
		{
			CurrentTime += 0.01f;
		}
		if (ResourceCount < ResourceLimit && CurrentTime > SetDelay /*&& RandomSpawnRange <= RandomValue*/ )
		{
			CurrentTime = 0f;
			Instantiate(Enemy, new Vector3(Random.Range(SpawnRangeMinX  , SpawnRangeMaxX), 3, Random.Range(SpawnRangeMinZ, SpawnRangeMaxZ)), Quaternion.identity);
			Debug.Log ("spawning");
		}

		//Debug.Log("ResourceObjects: " + ResourceCount);

		ResourceCount = GameObject.FindGameObjectsWithTag("Enemy").Length;

		
	}
}
