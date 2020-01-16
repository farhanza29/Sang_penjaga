using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GOLD : MonoBehaviour {
	public GameObject halangane;
	public GameObject halangan;
	public int value;
	public GameObject pickupEffect;
	public AudioSource sfx;

	//public AudioSource sfx;
	//public ParticleSystem dust;
	//public GameObject pickupEffect;

	// Use this for initialization
	void Start () {
		//dust.Stop ();
	}
	
	// Update is called once per frame
	void Update () {
		sfx.volume=PlayerPrefs.GetFloat("FxVolume");
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {

			FindObjectOfType<GameManager> ().AddGold (value);
	
	
			Instantiate(pickupEffect, transform.position, transform.rotation);
			Instantiate(halangane, transform.position, transform.rotation);
			sfx.Play ();

			//FindObjectOfType <halanganEffect> ().PE ();
			Destroy (halangan);

			Destroy (gameObject);

		}  
			
		
	}

}
