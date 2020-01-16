using UnityEngine;
using System.Collections;

public class playcam : MonoBehaviour
{
public Animator animCam;
	// Use this for initialization
	void Start ()
	{
		animCam.GetComponent<Animator> ();
	

	}
	
	// Update is called once per frame
	public void playingg()
	{
		if(Input.GetKeyDown (KeyCode.L))
		animCam.SetTrigger ("play");
		Debug.Log ("uigi");
		
	}
}

