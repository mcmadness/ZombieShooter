using UnityEngine;
using System.Collections;

public class zombieMove : MonoBehaviour {


	public float zombieSpeed;
	GameObject Player ;

	void Start(){

		Player = GameObject.FindGameObjectWithTag ("Player");


	}


	// Update is called once per frame
	void Update () {



		if (Vector3.Distance (transform.position, Player.transform.position) > .01f) {
			//stopping distance only move if we are more that .5 units away
			transform.position += Vector3.Normalize (Player.transform.position - transform.position) * Time.deltaTime * zombieSpeed;
			//mulitplying by time.deltatime will make it framerate independent



		}


	}


	void OnDrawGizmos () {
		Gizmos.DrawLine (transform.position, Player.transform.position);



	}
}
