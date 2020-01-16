using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GOLD2 : MonoBehaviour {
	public float hitter;
	public float exploTime;
	public float knockTime;
	public GameObject Messs;
	public ParticleSystem EP;
	public float speed =1;
	public int direction=1;
	Rigidbody Enemy;
	//public ParticleSystem HE;
	// Use this for initialization
	void Start ()
	{

	}

	// Update is called once per frame
	void Update ()
	{
		transform.Translate(Vector3.forward*speed*direction*Time.deltaTime);
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag=="Finish"){

			Rigidbody Enemy = GetComponent<Rigidbody> ();
			if (Enemy != null) {
				//	Enemy.useGravity = true;
				Vector3 hitDirection = Enemy.transform.position - transform.position;
				hitDirection = hitDirection.normalized * hitter;
				Enemy.AddForce (hitDirection);
				//HE.Play ();

			StartCoroutine (Destroyer());
			StartCoroutine (Destroyer2());
			//HE.Play ();
		
	

			}
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
}