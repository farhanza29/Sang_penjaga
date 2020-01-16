using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAngkot : MonoBehaviour {
	public float speed =1;
	public int direction=1;
	public GameObject angkotGO;
	public GameObject partikelHit;
	//public GameObject hiteffek;


	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {

		transform.Translate(Vector3.forward*speed*direction*Time.deltaTime);

	}
	void disableeee(){
		
	}
	void enableeee(){
		angkotGO.SetActive(true);
		partikelHit.SetActive(false);
	}

	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag=="Finish"){
			angkotGO.SetActive(false);
			partikelHit.SetActive(true);
		}
	}
}
