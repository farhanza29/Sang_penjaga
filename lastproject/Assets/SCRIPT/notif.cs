using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notif : MonoBehaviour {

	// Use this for initialization
	public static bool NotifPause = false;

	public GameObject tutorUI;
	public GameObject batikUI;
	public GameObject batikUI2;
	public GameObject batikUI3;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.I)) {
			NotifPause = true;
		}
		if (NotifPause) {
			tutorial ();
		} 
		else {
			resume ();
		}

	}

	public void tutorial(){
		tutorUI.SetActive (true);
		Time.timeScale = 0f;
		NotifPause = true;
	}
	public void batik(){
		batikUI.SetActive (true);
		Time.timeScale = 0f;
		NotifPause = true;
	}
	public void batik2(){
		batikUI2.SetActive (true);
		Time.timeScale = 0f;
		NotifPause = true;
	}
	public void batik3(){
		batikUI3.SetActive (true);
		Time.timeScale = 0f;
		NotifPause = true;
	}
	public void resume(){
		
		batikUI.SetActive (false);
		batikUI2.SetActive (false);
		batikUI3.SetActive (false);
		tutorUI.SetActive (false);
		Time.timeScale = 1f;
		NotifPause = false;
			}
	}
