using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hidrant : MonoBehaviour {
	public ParticleSystem PRP;
	public ParticleSystem EP;
	public float knockTime;
	public float exploTime;
	public GameObject Messs;
	//public GameObject lampu;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Finish") {
			StartCoroutine (Destroyer());
			StartCoroutine (Destroyer2());
			PRP.Play ();
		
		}
	}

	public IEnumerator Destroyer(){
		yield return new WaitForSeconds (knockTime);
		Destroy (gameObject);
	}
	public IEnumerator Destroyer2(){
		yield return new WaitForSeconds (exploTime);
		EP.Play();
	//	Messs.SetActive (false);
	}
}
