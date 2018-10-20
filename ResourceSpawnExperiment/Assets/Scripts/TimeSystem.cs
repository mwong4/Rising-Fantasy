using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSystem : MonoBehaviour {

    public float currentTime;
    public float TimeChange;
    public float PhaseIncreasePercent;

    //Phases
    public float BuildingPhase;
    public float CollectingPhase;
    public float SpawningPhase;
    public float BattlingPhase;
    public float EndCycle;

    public float CurrentPhase;

    int EnemyCount;

	// Use this for initialization
	void Start () {

        currentTime = 0f;
        CurrentPhase = 1f;

		
	}
	
	// Update is called once per frame
	void Update () {

        EnemyCount = GameObject.FindGameObjectsWithTag("RawWoodResource").Length;

        currentTime += TimeChange;


        if(BuildingPhase < currentTime  && CurrentPhase == 1){
            CurrentPhase = 2f;

            //do something
        }

        if (CollectingPhase < currentTime && CurrentPhase == 2)
        {
            CurrentPhase = 3f;

            //do something
        }

        if (SpawningPhase < currentTime && CurrentPhase == 3)
        {
            CurrentPhase = 4f;

            //do something
        }

        if (BattlingPhase < currentTime && CurrentPhase == 4 || EnemyCount < 0 && CurrentPhase == 4)
        {
            CurrentPhase = 5f;

            //do something
        }

        if (EndCycle < currentTime && CurrentPhase == 5)
        {
            currentTime = 0f;
            CurrentPhase = 1f;

            //do something
        }

        if (EndCycle < currentTime && CurrentPhase == 4)
        {
            CurrentPhase = 5f;
            //do something
        }
        if (currentTime < (EndCycle + 1) && CurrentPhase == 5){
            
            currentTime = 0f;
            CurrentPhase = 1f;

            BuildingPhase = BuildingPhase + PhaseIncreasePercent;
            CollectingPhase = CollectingPhase + PhaseIncreasePercent;
            SpawningPhase = SpawningPhase + PhaseIncreasePercent;
            BattlingPhase = BattlingPhase + PhaseIncreasePercent;
            EndCycle = EndCycle + PhaseIncreasePercent;
        }
		
	}
}
