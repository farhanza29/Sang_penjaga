using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpad : MonoBehaviour {
	public Animator animator;
	public AudioSource playAS;
	public ParticleSystem JP;

	//public AudioClip jumpadSound;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
	//	playAS = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		playAS.volume=PlayerPrefs.GetFloat("FxVolume");
	}
	void OnTriggerEnter(Collider col){

		if (col.gameObject.tag == "Player") {
			//jump ();
		//	animator.Play("jump");
			animator.SetTrigger("jumpadA");
			playAS.Play();
			JP.Play ();
		}
}
//	public void VolumePrefs3()
///	{
//		
//		PlayerPrefs.SetFloat ("FxVolume", playAS.volume);
	//}

}
