using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pauseSoundVolume : MonoBehaviour {
	public AudioSource music;
	public AudioSource fxv;
	public  Slider volumep;
	public Slider fxVolumep;
	// Use this for initialization
	//public GameObject healthSound;

	void Start () {
	//	healthSound = FindObjectOfType<healthManager> ();
		//music.volume = PlayerPrefs.GetFloat ("MusicVolume");
	//	FindObjectOfType<audioManager> ().VolumePrefs();
	volumep.value = PlayerPrefs.GetFloat("MusicVolume");
		fxVolumep.value = PlayerPrefs.GetFloat ("FxVolume");
		//fxVolumep.value = PlayerPrefs.GetFloat ("FxVolume2");

	}
	
	// Update is called once per frame
	void Update () {
		music.volume = volumep.value;
		fxv.volume = fxVolumep.value;

	}

	public void VolumePrefs2()
	{
		PlayerPrefs.SetFloat ("MusicVolume", music.volume);
		PlayerPrefs.SetFloat ("FxVolume", fxVolumep.value);
//		PlayerPrefs.SetFloat ("FxVolume2", fxv.volume);
	}
}
