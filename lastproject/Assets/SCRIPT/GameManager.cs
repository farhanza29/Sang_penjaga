using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class GameManager : MonoBehaviour {

	public int currentGold;
	public TextMeshProUGUI goldText;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void AddGold(int goldToAdd)
	{
		currentGold += goldToAdd;
		goldText.text =currentGold+"/4";
	}




}
