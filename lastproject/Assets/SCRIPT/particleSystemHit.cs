using UnityEngine;
using System.Collections;

public class particleSystemHit : MonoBehaviour
{
	public ParticleSystem HE;
	public ParticleSystem HPE;
	public ParticleSystem HBPE;
	public AudioSource wallB;

	//public ParticleSystem PP;
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		wallB.volume=PlayerPrefs.GetFloat("FxVolume");
	}
	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.CompareTag("Enemy")){
			
				HE.Play ();

			}
		if(other.gameObject.CompareTag("Pembatas")){

			HPE.Play ();
			wallB.Play ();
		}
		if(other.gameObject.CompareTag("besi pembatas")){

			HBPE.Play ();
		}

	








}
}
