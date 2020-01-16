using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove: MonoBehaviour {
	private Transform lookAt;
	private Vector3 startOffset;
	private Vector3 moveVector;
	// Use this for initialization
	void Start () {
		lookAt = GameObject.FindGameObjectWithTag ("Player").transform;
		startOffset = transform.position - lookAt.position;
	}
	
	// Update is called once per frame
	void Update () {
		moveVector = lookAt.position + startOffset;

		//x
		moveVector.x=2;

		moveVector.y=9;

		//y
		moveVector.y=Mathf.Clamp(moveVector.y,15,50);
		transform.position =moveVector;
	}
}
