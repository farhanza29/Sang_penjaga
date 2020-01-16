using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class sceneTransition : MonoBehaviour
{
	public Animator animtransisi;
	public string sceneName;
	public float loS;
	public void Start(){

		animtransisi.GetComponent<Animator> ();
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {
			animtransisi.SetTrigger ("end");
			StartCoroutine("LS");

		}

}
	public IEnumerator LS(){


		yield return new WaitForSeconds (loS);
		SceneManager.LoadScene (sceneName);
	}
}

