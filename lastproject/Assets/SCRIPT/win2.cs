using UnityEngine;
using System.Collections;
using UnityEngine.Playables;

public class win2 : MonoBehaviour
{
	//public AudioSource SoundButton;
	public GameObject batikWin;
	public pauseSoundVolume BGM;
	public AudioSource musicWin;
	//public bool soundPlayed;
	//public Animator anim;
	// Use this for initialization
	void Start ()
	{
//		musicWin.GetComponent<AudioSource> ();
		//SoundButton = GetComponent<AudioSource> ();
	//	soundPlayed = false;
		//anim.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	//void Update ()

	//{
//		musicWin.volume=PlayerPrefs.GetFloat("MusicVolume");
		//	SoundButton.volume=PlayerPrefs.GetFloat("MusicVolume");

	//}

	public void OnTriggerEnter(Collider collider)
	{
		if (collider.gameObject.CompareTag ("Player")) {
			musicWin.Play();
			BGM.music.Stop();


			PlayableDirector pd = batikWin.GetComponent<PlayableDirector> ();
			//BGM.music.Stop();
			if (pd != null) {
				pd.Play ();
				FindObjectOfType<playerMovement> ().winning();
			playerMovement moveing = collider.GetComponent<playerMovement>();
			moveing.gerak = false;
			moveing.loncat = false;
			moveing.serang = false;
			//moveing.attackSound;

			//anim.SetTrigger("win2");
			//Time.timeScale = 0f;
			//	BGM.music.Stop();
			//	SoundButton.Play ();
			//	soundPlayed = true;

			}
		}  
	}

	public void baca(){
		BGM.music.Stop();
		musicWin.Play();
		PlayableDirector pd = batikWin.GetComponent<PlayableDirector> ();
		//BGM.music.Stop();
		if (pd != null) {
	

			pd.Evaluate ();
	}
}
}

