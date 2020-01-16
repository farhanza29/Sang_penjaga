using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {
	private healthManager hm;
	public GameObject efekHitam;
	public GameObject efekHijau;
	public Animator anim;
	public AudioSource sfx;
	// Use this for initialization
	void Start () {
		hm = FindObjectOfType<healthManager> ();
		anim.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		sfx.volume=PlayerPrefs.GetFloat("FxVolume");
	}
	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag =="Player"){
			hm.currentCheckpoint = gameObject;
			efekHijau.SetActive (true);
			efekHitam.SetActive (false);
			anim.SetTrigger("CP");
			sfx.Play ();
		}
}
}

