using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class healthManager : MonoBehaviour {
//	public Animator anim;
	public int maxHealth;
	public int currentHealth;
	public TextMeshProUGUI heartText;
	public playerMovement thePlayer;
	public enemiMental theEnemy;
//  public GameObject AA;
//	public AudioSource gameOver;

	public float invincibilityLength;
	private float invincibilityCounter;

	public Renderer playerRenderer;
	public Renderer weaponRenderer;

	private float flashCounter;
	public float flashLength = 5f;

	private bool isRespawning;
	//private Vector3 RespawnPoint;
	public GameObject currentCheckpoint;
	public float respawnLength;
// Use this for initialization

	void Start () {
		currentHealth = maxHealth;
		thePlayer = FindObjectOfType<playerMovement>();
		theEnemy = FindObjectOfType<enemiMental>();
       // RespawnPoint = transform.position;
// anim=GetComponents<Animator>();
	}

	// Update is called once per frame
	void Update () {
		heartText.text = "x" + currentHealth;
		if(currentHealth > maxHealth)
		{
			currentHealth = maxHealth;
		}
	//	if(currentHealth < 1)
	//	{
	//	FindObjectOfType<gameover2> ().Death;
	//		anim.SetTrigger("gameOver");
	//	Debug.Log ("fs");
	//SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex - 1);
	//	gameOver.Play();
	//	}

		if (invincibilityCounter > 0) {
			invincibilityCounter -= Time.deltaTime;
			flashCounter -= Time.deltaTime;

	   if (flashCounter<=0){
				playerRenderer.enabled = !playerRenderer.enabled;
				flashCounter = flashLength;
			}

	   if (invincibilityCounter <= 0) {
				playerRenderer.enabled = true;
			}
		}
	}

	public void HurtPlayer(int damage)
	{
		if (invincibilityCounter <= 0) {
			currentHealth -= damage;
			invincibilityCounter = invincibilityLength;
			Respawn ();
			playerRenderer.enabled = false;
				flashCounter = flashLength;
		}
	}


	public void Respawn(){
		//thePlayer.transform.position = currentCheckpoint.transform.position;
		if(!isRespawning){
		StartCoroutine ("RespawnCo");
		}
	}

	public IEnumerator RespawnCo(){
		isRespawning = true;
		thePlayer.gameObject.SetActive (false);
		yield return new WaitForSeconds (respawnLength);
		isRespawning = false;
		thePlayer.gameObject.SetActive (true);
		thePlayer.transform.position = currentCheckpoint.transform.position;
	}

	public void AddHeart(int heartToAdd)
	{
		currentHealth += heartToAdd;

	}






}
