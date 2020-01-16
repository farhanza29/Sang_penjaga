using UnityEngine;
using System.Collections;

public class sfxTrap : MonoBehaviour
{
	public AudioSource sfx;
// Use this for initialization
void Start ()
{

}

// Update is called once per frame
void Update ()
{
	sfx.volume=PlayerPrefs.GetFloat("FxVolume");
}
private void OnTriggerEnter(Collider other)
{
	if (other.tag == "trapOut") {
		sfx.Play ();


	}  
}
}
