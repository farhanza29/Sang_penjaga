using UnityEngine;
using System.Collections;

public class knockback : MonoBehaviour
{
	public float hitter;
	public float hitter2;
	//public float knockTime;
	//public ParticleSystem HE;
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Enemy")) {
			Rigidbody Enemy = other.GetComponent<Rigidbody> ();
			if (Enemy != null) {
			//	Enemy.useGravity = true;
				Vector3 hitDirection = Enemy.transform.position - transform.position;
				hitDirection = hitDirection.normalized * hitter;
				Enemy.AddForce (hitDirection);
				//HE.Play ();

			}
		}
			if (other.gameObject.CompareTag ("Prop")) {
				Rigidbody Prop = other.GetComponent<Rigidbody> ();
				if (Prop != null) {
					//	Enemy.useGravity = false;
					Vector3 hitDirection = Prop.transform.position - transform.position;
					hitDirection = hitDirection.normalized * hitter2;
					Prop.AddForce (hitDirection);
					//HE.Play ();

				}
			}



	}
}



