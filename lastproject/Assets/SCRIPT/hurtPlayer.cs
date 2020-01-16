using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hurtPlayer : MonoBehaviour {

	public int damegeToGive;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag =="Player"){

			//Vector3 hitDirection = other.transform.position - transform.position;
			//hitDirection = hitDirection.normalized;
	
			FindObjectOfType<healthManager> ().HurtPlayer (damegeToGive);
		}
	}
}



//FindObjectOfType<healthManager> ().HurtPlayer (damegeToGive);//, hitDirection);
