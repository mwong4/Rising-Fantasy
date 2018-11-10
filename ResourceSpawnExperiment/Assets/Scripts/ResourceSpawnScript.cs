using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceSpawnScript : MonoBehaviour {

    public GameObject Resource;

    int ResourceCount;
    public int ResourceLimit;

    float CurrentTime;
    public float SetDelay;

    //Min spawn range
    public float SpawnRangeMinX;
    public float SpawnRangeMinZ;

    //Max spawn range
    public float SpawnRangeMaxX;
    public float SpawnRangeMaxZ;

    //public bool collectionPhase;

	public GameObject myPhases;



	// Use this for initialization
	void Start () {

		myPhases = GameObject.FindWithTag ("Phases").GetComponent<TimeSystem> ();


		
	}
	
	// Update is called once per frame
	void Update () {

        if (ResourceCount < ResourceLimit && CurrentTime < SetDelay)
        {
            CurrentTime += 0.01f;
        }
        if (ResourceCount < ResourceLimit && CurrentTime > SetDelay)
        {
            CurrentTime = 0f;
            if (myPhases.collectionPhase == true)
            {
                Instantiate(Resource, new Vector3(Random.Range(SpawnRangeMinX, SpawnRangeMaxX), 3, Random.Range(SpawnRangeMinZ, SpawnRangeMaxZ)), Quaternion.identity);
            }
        }

        //Debug.Log("ResourceObjects: " + ResourceCount);

        ResourceCount = GameObject.FindGameObjectsWithTag("RawWoodResource").Length;







		
	}
}
