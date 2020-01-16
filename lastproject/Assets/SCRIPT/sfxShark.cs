using UnityEngine;
using System.Collections;

public class sfxShark : MonoBehaviour
{
	public AudioSource sfx;
	public ParticleSystem SP;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		sfx.volume=PlayerPrefs.GetFloat("FxVolume");
	}


	private void OnTriggerEnter (Collider other)
	{
		if (other.tag == "shark") {
			sfx.Play ();
			SP.Play ();

		}
	}

}

