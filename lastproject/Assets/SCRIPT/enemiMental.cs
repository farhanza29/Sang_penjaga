using UnityEngine;
using System.Collections;

public class enemiMental : MonoBehaviour
{	public float exploTime;
	public float knockTime;
	public GameObject Messs;
	public ParticleSystem EP;
	public float speed =1;
	public int direction=1;
	Animator anim;
	BoxCollider BC;
	public float BCT;
	public float hancur;

	//public ParticleSystem HE;
	// Use this for initialization
	void Start ()
	{
	anim = GetComponent<Animator> ();
		BC = GetComponent<BoxCollider> ();
		StartCoroutine (hancurkan());
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		transform.Translate(Vector3.forward*speed*direction*Time.deltaTime);
	
	}

	 void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag=="Finish"){
		//	anim.StopPlayback ();
			StartCoroutine (Destroyer());
			StartCoroutine (Destroyer2());
			//HE.Play ();
			if (anim != null) {
				anim.SetTrigger ("berhenti");
		//		BC.enabled = !BC.enabled;
				StartCoroutine (DestroyerBC());
			}
		}
		if (other.gameObject.tag == "hancur") {
			Destroy (gameObject);
		}

	}

		
	public IEnumerator Destroyer(){
			yield return new WaitForSeconds (knockTime);
			Destroy (gameObject);
}
	public IEnumerator Destroyer2(){
		yield return new WaitForSeconds (exploTime);
		EP.Play();
		Messs.SetActive (false);
	}
	public IEnumerator DestroyerBC(){
		yield return new WaitForSeconds (BCT);
		BC.enabled = !BC.enabled;
	}

	public IEnumerator hancurkan(){
		yield return new WaitForSeconds (hancur);
		Destroy (gameObject);
	}
}

