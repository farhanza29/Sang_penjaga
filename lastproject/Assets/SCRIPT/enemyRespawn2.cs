using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyRespawn2 : MonoBehaviour {
	public GameObject enemy;
	public GameObject pe;
	public float spawnTime;
	public float spawnDelay;
	public ParticleSystem EP;
	public Transform[] spawnPoints;
	// Use this for initialization
	void Start () {
		
	InvokeRepeating ("Spawn", spawnTime, spawnDelay);
	}

	void Update ()
	{
	//	StartCoroutine (Destroyer());
	}
	
	// Update is called once per frame
	public void Spawn () {
		int spawnPointIndex = Random.Range (0, spawnPoints.Length);
		Instantiate(pe, spawnPoints[spawnPointIndex].position, spawnPoints [spawnPointIndex].rotation);
		Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints [spawnPointIndex].rotation);

	
	}
//	public IEnumerator Destroyer(){
		//yield return new WaitForSeconds (3);
	////	EP.Play ();
//	}


}

/*
 public GameObject Spawne;
 public bool StopSpawning=false;
 public float spantTime;
 public floar spawnDelay;

start
InvokeReapting("SpawnObject",SpawnTime,SpawnDelay);

void spawnobject
instatiate()spawne;
 */
