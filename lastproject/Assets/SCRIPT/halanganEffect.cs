using UnityEngine;
using System.Collections;

public class halanganEffect : MonoBehaviour
{
	//public GameObject hal;
	public ParticleSystem ps;
	public AudioSource sfx;
	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update ()
	{
		sfx.volume=PlayerPrefs.GetFloat("FxVolume");
	}

	public void PE(){

		Instantiate(ps, transform.position, transform.rotation);
		//Destroy (hal);
		Destroy(gameObject);
	}

}
