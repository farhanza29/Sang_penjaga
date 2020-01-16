using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButonSound : MonoBehaviour
{
	public AudioSource soundButton;

	void Start () {

		soundButton = GetComponent<AudioSource> ();
		//soundButton.Play ();
	}
	void Update(){
		soundButton.volume=PlayerPrefs.GetFloat("FxVolume");
	}

	public void playSoundButton(){
		
			soundButton.Play ();
		
	}

}

