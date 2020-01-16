using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class jawab3 : MonoBehaviour {
	public string levellolos;
	public string levelgagal;
	public GameObject kuis;
	public GameObject hasil;
	// Use this for initialization
	void Start () {
		
	}
	public void quizz () {
		kuis.SetActive (true);
	}
	public void Hasil() {
		hasil.SetActive (false);
	}
	// Update is called once per frame
	public void jawaban(){
		
			int skor = PlayerPrefs.GetInt ("skor");
			PlayerPrefs.SetInt ("skor", skor);
					
		if (skor == 30) {
			SceneManager.LoadScene (levellolos);
		} else {
			quizz ();
			Hasil ();
			PlayerPrefs.DeleteAll();
		}

	}

}