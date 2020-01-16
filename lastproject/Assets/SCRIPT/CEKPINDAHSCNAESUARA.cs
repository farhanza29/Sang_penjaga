using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CEKPINDAHSCNAESUARA : MonoBehaviour {

public Animator animtransisi;
	public string sceneName;
	public float loS;

	public void Start(){

		animtransisi.GetComponent<Animator> ();
	}
	public void pindah()
	{		
		animtransisi.SetTrigger ("end");
		StartCoroutine("LS");
		//SceneManager.LoadScene(sceneName);
	}
	public IEnumerator LS(){
		
		yield return new WaitForSeconds (loS);
		SceneManager.LoadScene(sceneName);
}
}