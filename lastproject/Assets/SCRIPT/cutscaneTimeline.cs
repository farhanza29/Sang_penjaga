using UnityEngine;
using System.Collections;
using UnityEngine.Playables;


public class cutscaneTimeline : MonoBehaviour
{
	public AudioSource soundButton;
	public GameObject kebelakanga;
	public GameObject TextBox;
	public GameObject pkayCS;


	void Start () {
		soundButton = GetComponent<AudioSource> ();
	}

	void Update(){
		soundButton.volume=PlayerPrefs.GetFloat("FxVolume");
		}
	public void PlayTL ()
	{
		PlayableDirector pd = kebelakanga.GetComponent<PlayableDirector> ();
		if (pd != null) {
			pd.Play ();


		}

	}
	public void offCanvas()
	{
		soundButton.Play ();
		TextBox.SetActive (false);
		pkayCS.SetActive (false);

	}
}