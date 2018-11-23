using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamShake : MonoBehaviour {

	public Animator canAnim;

	public void CamShake_ (){
		canAnim.SetTrigger("shake");
	}
}
