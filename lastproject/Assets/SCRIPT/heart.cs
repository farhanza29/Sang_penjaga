using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heart : MonoBehaviour {

	public int value;
	public GameObject ps;
	public AudioSource sfx;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		sfx.volume=PlayerPrefs.GetFloat("FxVolume");
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") 
		{

			FindObjectOfType<healthManager> ().AddHeart (value);

			Instantiate (ps, transform.position, transform.rotation);
		
			sfx.Play ();

			Destroy (gameObject);
		}
	}
}
//0.018116