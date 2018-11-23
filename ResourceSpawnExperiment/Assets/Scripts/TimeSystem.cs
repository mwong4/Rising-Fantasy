using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeSystem : MonoBehaviour {

    public float currentTime;
    public float TimeChange;
    public float PhaseIncreasePercent;

	public float currentChanged;

	//Current UI text
	public Text myPhasesText;

    //Phases
    public float BuildingPhase;
    public float CollectingPhase;
    public float SpawningPhase;
    public float BattlingPhase;
    public float EndCycle;


    //Objects
  //  public GameObject ResourceSpawnSystem;
  //  public ResourceSpawningScript resourceSpawningScript;

    public float CurrentPhase;

    int EnemyCount;

	public bool collectionPhase;
	public bool spawningPhase;


	//referencing the phases bar
	public GameObject phasesBar;
	public Image image;

	// Use this for initialization
	void Start () {

        currentTime = 0f;
        CurrentPhase = 1f;

		phasesBar = GameObject.FindWithTag ("ExperienceBar");

		myPhasesText.text = "Building Phase";



       // GameObject ResourceSpawnSystem = GameObject.FindGameObjectWithTag("ResourceSpawning");// Get resource script
       // resourceSpawningScript = ResourceSpawnSystem.GetComponent<ResourceSpawnScript>();

		
	}
	
	// Update is called once per frame
	void Update () {



        EnemyCount = GameObject.FindGameObjectsWithTag("RawWoodResource").Length;

        currentTime += TimeChange;

		image.fillAmount = (currentTime/((100 + currentChanged))) - (CurrentPhase - 1);

		//Debug.Log (image.fillAmount);

        if(BuildingPhase < currentTime  && CurrentPhase == 1){
            CurrentPhase = 2f;

			myPhasesText.text = "Resource Phase";

            //do something

			collectionPhase = true;
        }

        if (CollectingPhase < currentTime && CurrentPhase == 2)
        {
            CurrentPhase = 3f;
			collectionPhase = false;
			spawningPhase = true;

			myPhasesText.text = "Spawning Phase";

        }

        if (SpawningPhase < currentTime && CurrentPhase == 3)
        {
            CurrentPhase = 4f;
			spawningPhase = false;


			myPhasesText.text = "Fighting Phase";
	

            //do something
        }

        if (BattlingPhase < currentTime && CurrentPhase == 4 || EnemyCount < 0 && CurrentPhase == 4)
        {
            CurrentPhase = 5f;

			myPhasesText.text = "Cooldown Phase";


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
			currentChanged = currentChanged + PhaseIncreasePercent;
        }
		
	}
}
