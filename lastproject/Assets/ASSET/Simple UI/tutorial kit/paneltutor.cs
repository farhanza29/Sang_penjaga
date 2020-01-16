using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paneltutor : MonoBehaviour {
	public Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		anim.SetBool ("tutorIn",true);
	}
	
	// Update is called once per frame
	void Update () {
		handleInput ();
	}
	void handleInput(){
	
		if (Input.GetKeyDown (KeyCode.Escape)){
			anim.SetBool ("tutorIn", false);
		}
		if(Input.GetKeyDown (KeyCode.I)){
			anim.SetBool ("tutorIn", true);
		
		}
	}
	public void close(){
		anim.SetBool ("tutorIn", false);
	}
}
