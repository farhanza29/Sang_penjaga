using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class skor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt ("skor", 0);
	}
	
	// Update is called once per frame
	void Update () { 
		GetComponent<TextMeshProUGUI> ().text = PlayerPrefs.GetInt ("skor").ToString();
	}
}
