using UnityEngine;
using System.Collections;

public class soundclick : MonoBehaviour
{
	public AudioSource soundButton;
	// Use this for initialization
	void Start ()
	{

	}


	void Update(){
		soundButton.volume=PlayerPrefs.GetFloat("FxVolume");
	}
	// Update is called once per frame
	public void buttonlicked()
	{
		soundButton.Play ();
	}
}

