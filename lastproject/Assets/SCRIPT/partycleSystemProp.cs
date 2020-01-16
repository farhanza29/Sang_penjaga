using UnityEngine;
using System.Collections;

public class partycleSystemProp : MonoBehaviour
{
	public ParticleSystem HL;
	public GameObject sinar;


//public ParticleSystem PP;
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
	if(other.gameObject.CompareTag("Finish")){

		HL.Play ();
			sinar.SetActive (false);
	}


}
}
