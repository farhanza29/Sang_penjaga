using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class musicmanagerstry : MonoBehaviour {
	
	public AudioSource music;
	// Use this for initialization
	void Start () {
		
		//Time.timeScale = 1f;
		music.volume = PlayerPrefs.GetFloat ("MusicVolume");
	
	}
}
