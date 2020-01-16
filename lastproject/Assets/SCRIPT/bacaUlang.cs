using UnityEngine;
using System.Collections;

public class bacaUlang : MonoBehaviour
{
	public float loS;
	public Animator animtransisi;
	// Use this for initialization
	void Start ()
	{
		animtransisi.GetComponent<Animator> ();
	}

	public void pindah()
	{		
		animtransisi.SetTrigger ("end");
		StartCoroutine("LS");

	}
	public IEnumerator LS(){

		yield return new WaitForSeconds (loS);

	}


}

