using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceSpawnScript : MonoBehaviour {

	public GameObject TreeResource;
	public GameObject TreeResourceTwo;

	public GameObject RockResource;
	public GameObject RockResourceTwo;
	public GameObject RockResourceThree;

	public int treeResourceCount;
	public int treeTwoResourceCount;

	public int rockResourceCount;
	public int rockTwoResourceCount;
	public int rockThreeResourceCount;

	public int treeResourceLimit;
	public int treeTwoResourceLimit;

	public int rockResourceLimit;
	public int rockTwoResourceLimit;
	public int rockThreeResourceLimit;

	float CurrentTime;
	public float SetDelay;

	//Min spawn range
	public float SpawnRangeMinX;
	public float SpawnRangeMinZ;

	//Max spawn range
	public float SpawnRangeMaxX;
	public float SpawnRangeMaxZ;

	//public bool collectionPhase;

	public TimeSystem myPhases;



	// Use this for initialization
	void Start () {

		myPhases = GameObject.FindWithTag ("Phases").GetComponent<TimeSystem> ();



	}

	// Update is called once per frame
	void Update () {

		if (treeResourceCount < treeResourceLimit && CurrentTime < SetDelay)
		{
			CurrentTime += 0.01f;
		}
		if (CurrentTime > SetDelay)
		{
			CurrentTime = 0f;
			if (myPhases.collectionPhase == true)
			{

				Debug.Log ("spawning");
				if (treeResourceCount < treeResourceLimit) {
					Instantiate (TreeResource, new Vector3 (Random.Range (SpawnRangeMinX, SpawnRangeMaxX), 4, Random.Range (SpawnRangeMinZ, SpawnRangeMaxZ)), Quaternion.identity);
				}

				if (treeTwoResourceCount < treeTwoResourceLimit) {
					Instantiate (TreeResourceTwo, new Vector3 (Random.Range (SpawnRangeMinX, SpawnRangeMaxX), 4, Random.Range (SpawnRangeMinZ, SpawnRangeMaxZ)), Quaternion.identity);
				}

				if (rockResourceCount < rockResourceLimit) {
					Instantiate (RockResource, new Vector3 (Random.Range (SpawnRangeMinX, SpawnRangeMaxX), 4, Random.Range (SpawnRangeMinZ, SpawnRangeMaxZ)), Quaternion.identity);
				}

				if (rockTwoResourceCount < rockTwoResourceLimit) {
					Instantiate (RockResourceTwo, new Vector3 (Random.Range (SpawnRangeMinX, SpawnRangeMaxX), 4, Random.Range (SpawnRangeMinZ, SpawnRangeMaxZ)), Quaternion.identity);
				}

				if (rockThreeResourceCount < rockThreeResourceLimit) {
					Instantiate (RockResourceThree, new Vector3 (Random.Range (SpawnRangeMinX, SpawnRangeMaxX), 4, Random.Range (SpawnRangeMinZ, SpawnRangeMaxZ)), Quaternion.identity);
				}
			}
		}

		//Debug.Log("ResourceObjects: " + ResourceCount);

		treeResourceCount = GameObject.FindGameObjectsWithTag("RawWoodResource").Length;
		treeTwoResourceCount = GameObject.FindGameObjectsWithTag("RawWoodResourceTwo").Length;
		rockResourceCount = GameObject.FindGameObjectsWithTag("RawRockResource").Length;
		rockTwoResourceCount = GameObject.FindGameObjectsWithTag("RawRockResourceTwo").Length;
		rockThreeResourceCount = GameObject.FindGameObjectsWithTag("RawRockResourceThree").Length;

	}
}
