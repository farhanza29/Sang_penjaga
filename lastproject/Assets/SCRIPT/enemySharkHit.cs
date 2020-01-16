using UnityEngine;
using System.Collections;

public class enemySharkHit : MonoBehaviour
{
	public Animation sharkAnim;
	public GameObject shark;
	public ParticleSystem sharkHitParticle;
	

	// Use this for initialization
	void Start ()
	{
		//sharkAnim.GetComponent<Animation> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}


	public void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag=="Finish"){
			sharkHitParticle.Play();
			shark.SetActive (false);
			sharkAnim.Stop ();
		}
}

}