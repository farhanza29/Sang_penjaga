using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap : MonoBehaviour {
	public GameObject jebakan;
//	public GameObject jebakan2;


	// Use this for initialization
	void Start () {
		jebakan.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void disable(){
		jebakan.SetActive(false);
	}
	void disable2(){
		jebakan.SetActive(true);
	}
	private void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			disable2 ();

		}

	}
	private void OnTriggerExit(Collider other){
		if (other.gameObject.tag == "Player") {
			disable ();
		}
	}
}
