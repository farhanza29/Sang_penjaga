using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startCheckpoint : MonoBehaviour {
	private healthManager hm;

	// Use this for initialization
	void Start () {
		hm = FindObjectOfType<healthManager> ();
	
	}

	// Update is called once per frame
	void Update () {

	}
	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag =="Player"){
			hm.currentCheckpoint = gameObject;
	
		}
	}
}

