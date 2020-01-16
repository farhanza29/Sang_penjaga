using UnityEngine;
using System.Collections;

public class gameover2 : MonoBehaviour
{
	public bool soundPlayed;
	public healthManager Health;
	public pauseSoundVolume BGM;
	public AudioSource musicGameover;
//	public GameObject life;
	 Animator anim;
	// Use this for initialization

	void Start(){
		musicGameover.GetComponent<AudioSource> ();
		soundPlayed = false;
	}

	void Awake(){
		anim=GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update ()
	{
		musicGameover.volume=PlayerPrefs.GetFloat("MusicVolume");
		if(Health.currentHealth<1 && !soundPlayed){
			//musicGameover.Play();
		//	Debug.Log ("rwqre");

		anim.SetTrigger("gameOver");
		//	Time.timeScale = 0f;
			BGM.music.Stop();
		
			musicGameover.Play();
			soundPlayed = true;
			StartCoroutine(deathsplash());
		}

		}
	IEnumerator deathsplash(){
		
		yield return new WaitForSeconds(1f);
		Time.timeScale = 0f;


	}

	}


