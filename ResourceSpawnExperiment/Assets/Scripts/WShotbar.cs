using UnityEngine;

public class WShotbar : MonoBehaviour {

	public int selectedWeapon = 0;
	public GameObject[] selections;
	// Use this for initialization
	void Start () {
		//selections = GameObject.FindGameObjectsWithTag ("selection");
		SelectWeapon(0);
	}

	// Update is called once per frame
	void Update () {

		int previousSelectedWeapon = selectedWeapon;

		if (Input.GetAxis ("Mouse ScrollWheel") > 0f) 
		{
			if (selectedWeapon >= selections.Length-1)
				selectedWeapon = 0;
			else
				selectedWeapon++;
				
			SelectWeapon(selectedWeapon);
		}
		if (Input.GetAxis ("Mouse ScrollWheel") < 0f) 
		{
			if (selectedWeapon <= 0f)
				selectedWeapon = selections.Length-1;
			else
				selectedWeapon--;
				
			SelectWeapon(selectedWeapon);
		}

		if (Input.GetKeyDown (KeyCode.Alpha1)) 
		{
			selectedWeapon = 0;
			SelectWeapon (0);
		}

		if (Input.GetKeyDown (KeyCode.Alpha2) && transform.childCount >= 2) 
		{
			selectedWeapon = 1;
			SelectWeapon (1);
		}

		if (Input.GetKeyDown (KeyCode.Alpha3) && transform.childCount >= 3) 
		{
			selectedWeapon = 2;
			SelectWeapon (2);
		}

		if (Input.GetKeyDown (KeyCode.Alpha4) && transform.childCount >= 4) 
		{
			selectedWeapon = 3;
			SelectWeapon (3);
		}



		//if (previousSelectedWeapon != selectedWeapon) 
		//{
		//	SelectWeapon ();
		//}
	}

	void SelectWeapon (int selection)
	{
		for(int i = 0; i<selections.Length;i++)
		{
			if (i == selection)
				selections[i].gameObject.SetActive (true);
			else
				selections[i].gameObject.SetActive (false);
		}

	}
}
