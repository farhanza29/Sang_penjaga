using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class talkanim : MonoBehaviour {
	public bool ngomong;
	public Animator animator;
	public Animator animator2;

	public void Talking(){
		ngomong = false;

		if (ngomong == false) {
			//animator.SetBool ("talking", true);
			//animator2.SetBool ("talkingP", false);

			Debug.Log ("cowo");
		ngomong = true;
	
		} else {
			//animator.SetBool ("talking", false);
		//	animator2.SetBool ("talkingP", true);
			//return(ngomong == false);
			Debug.Log ("cewe");
		 ngomong=false;
		}
	}
}