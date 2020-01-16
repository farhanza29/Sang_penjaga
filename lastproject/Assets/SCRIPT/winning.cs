using UnityEngine;
using System.Collections;
using TMPro;
public class winning : MonoBehaviour
{
	//Animator anim;
	public TextMeshProUGUI textDisplay;
	public string[] sentences;
	public GameObject textBox;
	private int index;
	public float typingSpeed;
	// Use this for initialization

	
	// Update is called once per frame
	void Update ()
	{

		if(textDisplay.text == sentences[index]){
		//	textBox.SetActive (true);
			StartCoroutine(Nexta());

		}

	}

	IEnumerator Type(){
		
		foreach(char letter in sentences[index].ToCharArray()){
			textDisplay.text += letter;
			yield return new WaitForSeconds (typingSpeed);

		}
	}

	IEnumerator Nexta(){
		yield return new WaitForSeconds (3f);
		NextSentence ();
	}

	public void NextSentence(){
		
		if (index < sentences.Length - 1) {
			index++;
			textDisplay.text = "";
			StartCoroutine (Type ());

		} else {
			textDisplay.text = "";
		
			//textBox.SetActive (true);
		
		}

	}

	private void OnTriggerEnter(Collider other)
	{
		
		//dust.Stop ();
		if (other.tag == "Player") {

		//	anim.SetTrigger("winning");
		
			textBox.SetActive (true);
			StartCoroutine (Type ());


}
	}
}

