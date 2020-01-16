using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {
	public float speed =1;
	public int direction=1;
	//public GameObject partikeleffek;
	//public GameObject hiteffek;


	// Use this for initialization
	void Start () {
	//	partikeleffek.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.Translate(Vector3.forward*speed*direction*Time.deltaTime);
	
	}

	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag=="Finish"){
		//	partikeleffek.SetActive(true);
			Destroy(gameObject);

		}
	}
}
