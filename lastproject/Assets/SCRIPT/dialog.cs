using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class dialog : MonoBehaviour {
	public AudioSource soundButton;
	public TextMeshProUGUI textDisplay;
	public string[] sentences;
	private int index;
	public float typingSpeed;
	public GameObject continueButton;
	public GameObject playTImeline;
	public GameObject Back;
	public GameObject textBox;
	//public bool ngomong;

	public Animator animator;
	public Animator animator2;

	void Start () {

		soundButton = GetComponent<AudioSource> ();
		StartCoroutine (Type());

	}

	void Update(){
		soundButton.volume=PlayerPrefs.GetFloat("FxVolume");
		if(textDisplay.text == sentences[index]){
			continueButton.SetActive (true);
			textBox.SetActive (true);
		

		}
	}

	IEnumerator Type(){
		foreach(char letter in sentences[index].ToCharArray()){
			textDisplay.text += letter;
			yield return new WaitForSeconds (typingSpeed);

		}
	}

	public void NextSentence(){

	
		continueButton.SetActive (false);

		if (index < sentences.Length - 1) {
			index++;
			textDisplay.text = "";
			StartCoroutine (Type ());
			soundButton.Play ();
		} else {
			textDisplay.text = "";
			continueButton.SetActive (false);
			textBox.SetActive (true);
			playTImeline.SetActive (true);
			Back.SetActive (true);
			soundButton.Play ();
		}

	}

	public void talk(){
		if (index % 2 != 0) {
			animator.SetTrigger ("talkP 0");
			Debug.Log ("cowo");
		} else {
			animator2.SetTrigger ("talking 0");
			Debug.Log ("cewe");
		}
	}



}
