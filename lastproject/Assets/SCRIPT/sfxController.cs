using UnityEngine;
using System.Collections;

public class sfxController : MonoBehaviour
{
	public GameObject sfxParticleSharkOut;
	public GameObject sfxParticleSharkIn;
	public GameObject sfxParticleSharkOut1;
	public GameObject sfxParticleSharkIn1;

	// Use this for initialization
	void Start ()
	{
		sfxParticleSharkIn.SetActive (false);
		sfxParticleSharkOut.SetActive (false);
		sfxParticleSharkIn1.SetActive (false);
		sfxParticleSharkOut1.SetActive (false);
	}
	
	// Update is called once per frame
	void Update ()
	{

	}


	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {
			sfxParticleSharkIn.SetActive (true);
			sfxParticleSharkOut.SetActive (true);
			sfxParticleSharkIn1.SetActive (true);
			sfxParticleSharkOut1.SetActive (true);
		}  
	}
	private void OnTriggerExit(Collider other)
	{
		if (other.tag == "Player") {
			sfxParticleSharkIn.SetActive (false);
			sfxParticleSharkOut.SetActive (false);
			sfxParticleSharkIn1.SetActive (false);
			sfxParticleSharkOut1.SetActive (false);
		}  
	}
}

