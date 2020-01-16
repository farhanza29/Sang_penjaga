using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {
	public AudioClip jumpSound;
	public AudioClip attackSound;
	public AudioClip [] clips;

	AudioSource playAS;


		public float runSpeed=2;
		public float gravity = -12;
		public float jumpHeight =1;
	  private Vector3 velocity;
		public float velocityY;

     	public bool attack;

	public ParticleSystem LP;

	public Animator animator;
	CharacterController controller;

	public bool gerak;
	public bool loncat;
	public bool serang;

	public float knockBackForce;
	public float knockBackTime;
	private float knockBackCounter;




	//MOVE bETTER

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		//LP = GetComponent<ParticleSystem> ();
		controller = GetComponent<CharacterController> ();
		velocityY = 0;
		gerak = true;
		loncat = true;
		serang = true;
	}
	private void Awake(){
		playAS = GetComponent<AudioSource> ();
	}
	// Update is called once per frame
	void Update ()
	{		
	//	pos = transform.position;
		movement ();
		handleInput ();
		playAS.volume=PlayerPrefs.GetFloat("FxVolume");

	}
		
	void FixedUpdate(){
		attack1 ();
		resetValues ();
	
	}

	public void movement(){
		
		if(knockBackCounter<=0){
		Vector2 input = new Vector2 (Input.GetAxisRaw ("Horizontal"), Input.GetAxisRaw ("Vertical"));
		Vector2 inputDir = input.normalized;
		
		if (gerak && inputDir != Vector2.zero) {
			transform.eulerAngles = Vector3.up * Mathf.Atan2 (inputDir.x, inputDir.y) * Mathf.Rad2Deg;
		} else {
			inputDir = Vector2.zero;
		}

		
		
		float speed = runSpeed * inputDir.magnitude;

		velocityY += Time.deltaTime * gravity;

		velocity = transform.forward * speed + Vector3.up * velocityY;
		controller.Move (velocity * Time.deltaTime);
		
		float animationSpeedPercent = 1 * inputDir.magnitude;
		animator.SetFloat ("speedPercent", animationSpeedPercent);
		
		}else{
			knockBackCounter -= Time.deltaTime;
		}
	
	//	if (animator.GetFloat ("speedPercent") ==1&&controller.isGrounded) {
		//	step ();
	//	}
	
		if (controller.isGrounded) {
			velocityY = 0;
			animator.SetBool ("fall", false);
			animator.SetBool ("loncat", false);
		}
		else {
			animator.SetBool ("fall", true);
		}	

	
	}
		

	void step(){
		AudioClip clip = GetRandomClip ();
		playAS.PlayOneShot (clip);
	}
	private AudioClip GetRandomClip()
	{
		return clips[UnityEngine.Random.Range(0,clips.Length)];
	}
		
	void attack1(){
		if(attack&&serang==true){
		animator.SetTrigger ("attack");
			playAS.clip = attackSound;
			playAS.Play ();
	}
	}

	public void jump(){
		if (controller.isGrounded) {
			velocityY = jumpHeight;
			animator.SetBool ("loncat", true);
			//playAS.clip = jumpSound;
			//playAS.Play ();
		} 
	}

	public void winning(){
		animator.SetTrigger ("F");
	}
//	public void victry(){
	//	if (controller.isGrounded) {
//			animator.SetTrigger("F");
//	}
//	}
	void OnTriggerEnter(Collider col){
		
			if (col.gameObject.tag == "jumpad") {
			//jump ();
				animator.SetBool ("loncat", true);
				velocityY = 55;
				animator.SetBool ("jumpad", true);
				animator.SetBool ("fall", false);
		}
		if (col.gameObject.tag == "pucuk") {
			KnockBack (velocity);
		}

		if (col.gameObject.tag == "aspal"){
			LP.Play ();
		}
	}

	void OnTriggerExit(Collider col){
		if (col.gameObject.tag == "jumpad") {
			animator.SetBool("fall",true);
			animator.SetBool("jumpad",false);
		}
	}
		

	void handleInput(){
		if (Input.GetKeyDown (KeyCode.Space)&&controller.isGrounded&&loncat==true) {
			jump ();
			playAS.clip = jumpSound;
			playAS.Play ();

		}
		if (Input.GetKeyDown (KeyCode.Mouse0)) {
			attack = true;
		}

//		if (Input.GetKeyDown (KeyCode.N) && controller.isGrounded) {
//				victry();
//		}
	}
	void resetValues()
	{
		attack = false;
	}


	public void KnockBack(Vector3 direction){

		knockBackCounter = knockBackTime;
	//direction = new Vector3 (1f, 1f, 1f);
		//controller.Move((velocity= -transform.forward*Time.deltaTime)* knockBackForce);
//velocityY = knockBackForce;
	}

	}













	//void Jump(){
//		if(controller.isGrounded){
	//		velocityY = 0;
	//	}
	//				if(controller.isGrounded){
	//					float jumpVellocity = Mathf.Sqrt (-2*gravity*jumpHeight);
	//		velocityY = jumpVellocity;

//	}
	
//			

					

//}



//GERAK
/*
 * 	public float runSpeed=2;

	Animator animator;
	CharacterController controller;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		controller = GetComponent<CharacterController> ();

	}
	// Update is called once per frame
	void Update ()
	{
		Vector2 input = new Vector2 (Input.GetAxisRaw ("Horizontal"), Input.GetAxisRaw ("Vertical"));
		Vector2 inputDir = input.normalized;


		if (inputDir != Vector2.zero) {
			transform.eulerAngles = Vector3.up * Mathf.Atan2 (inputDir.x, inputDir.y) * Mathf.Rad2Deg;
		}
		float speed = runSpeed* inputDir.magnitude;

		transform.Translate(transform.forward *speed*Time.deltaTime, Space.World);


		float animationSpeedPercent = 1 * inputDir.magnitude;
		animator.SetFloat ("speedPercent", animationSpeedPercent);

	}

}

*/
















	//	 {
		//	
	//	}	
			
	//	transform.Translate (transform.forward * Time.deltaTime, Space.World);


		//float animationSpeedPercent =(1)* inputDir.magnitude;
	//	animator.SetFloat ("speedPercent", animationSpeedPercent);


//



















