﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class audioManager : MonoBehaviour {
	
	public AudioSource music;
	public  Slider volume;
	public Slider fxVolume;

	// Use this for initialization
	void Start () {
		volume.value = PlayerPrefs.GetFloat ("MusicVolume");
		fxVolume.value = PlayerPrefs.GetFloat ("FxVolume");
	}
	
	// Update is called once per frame
	void Update () {
		
		music.volume = volume.value;
	}

	public void VolumePrefs()
	{
		PlayerPrefs.SetFloat ("MusicVolume", music.volume);
		PlayerPrefs.SetFloat ("FxVolume", fxVolume.value);
	}


}
