using UnityEngine;
using System.Collections;

public class musicManager : MonoBehaviour
{
	public AudioSource music;
	// Use this for initialization
	void Start ()
	{
		Time.timeScale = 1f;
		music.volume=PlayerPrefs.GetFloat("MusicVolume");
	}

}

