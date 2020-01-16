using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class c : MonoBehaviour {
	public Animator transitionAnim;
	public string sceneName;
	// Use this for initialization
	public void Start(){

		transitionAnim.GetComponent<Animator> ();
	}

	public void pindah()
	{		
		transitionAnim.SetTrigger ("end");
		StartCoroutine("LS");

	}
	public IEnumerator LS(){

		yield return new WaitForSeconds (1);
		SceneManager.LoadScene(sceneName);
	}

}


/*	public void change(){
		Debug.Log ("sdfsdaf");
		transitionAnim.SetTrigger ("end");
		//yield return new WaitForSeconds(1f);
		SceneManager.LoadScene(sceneName);
	}*/


