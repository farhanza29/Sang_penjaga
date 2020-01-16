using UnityEngine;
using System.Collections;

public class pauseOption : MonoBehaviour
{


	//public AudioSource playAS;
	public AudioSource soundButton;
	public GameObject puse;
	//public GameObject fadder;
	public GameObject option;


	private void Awake(){
	//	playAS = GetComponent<AudioSource> ();

	}
	// Update is called once per frame
	void Update ()
	{
		soundButton.volume=PlayerPrefs.GetFloat("FxVolume");
		if (Input.GetKeyDown (KeyCode.P)) {
			puse.SetActive (true);
			//fadder.SetActive (false);
			Time.timeScale = 0f;
		}
		if (option==true&& Input.GetKeyDown (KeyCode.P)) {
			puse.SetActive (true);
			option.SetActive (false);
			Time.timeScale = 0f;
		
		}
	

	}
	public void resume ()
	{
		Time.timeScale = 1f;
		puse.SetActive (false);
		soundButton.Play ();
	
	}

//	public void clickAnyButton(){
	//	playAS.clip = clickButton;
	//	playAS.Play ();
	//}
}

