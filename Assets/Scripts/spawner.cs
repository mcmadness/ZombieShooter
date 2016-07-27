using UnityEngine;
using System.Collections;

public class spawner : MonoBehaviour {

	public GameObject moreZombies;
	public float spawnTimer = 4f;
	public float firstSpawn = 5f; 


	void Start (){
		InvokeRepeating ("Spawn", firstSpawn, spawnTimer);




	}
	void Spawn () {
		Instantiate (moreZombies,
			new Vector3 ((transform.position.x + Random.Range(-.15f, .15f)), (transform.position.y + Random.Range(-.15f, .15f)), 0f) ,
			Quaternion.Euler (0f, 0f, 0f) );



	}
	void Update () {



	
	}
}
