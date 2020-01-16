using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour {
	public CapsuleCollider ss;
	public BoxCollider Depan;
	public  BoxCollider Belakang;
	public  BoxCollider Kanan;
	public  BoxCollider Kiri;
	//public GameObject cantingP;
	//public GameObject cantingB;
	//GameObject cantingPunggung;
	//GameObject cantingBawah;
	// Use this for initialization
	void Start () {
		disableeee ();
	}
	// Update is called once per frame
	void disableeee(){
		ss.enabled = false;
		Depan.enabled = false;
		Belakang.enabled = false;
		Kanan.enabled = false;
		Kiri.enabled = false;

	//	cantingP.SetActive(true);
		//cantingB.SetActive(false);

		//cantingPunggung = true;
		//cantingBawah = false;
	}
	void enableeee(){
		ss.enabled = true;
		Depan.enabled = true;
		Belakang.enabled = true;
		Kanan.enabled = true;
		Kiri.enabled = true;
		//cantingB.SetActive(true);
	//	cantingP.SetActive(true);
	//	cantingPunggung = false;
		//cantingBawah = true;
	}

}
