using UnityEngine;
using System.Collections;

public class bulletController : MonoBehaviour {
	Vector2 bulletDirection ;
	GameObject Player ;
	public float BulletSpeed = 4f;
	Rigidbody2D bulletRigidBody ;
	public float bulletLifeSpan = .75f ;

	void Start () {
		Player = GameObject.FindGameObjectWithTag ("Player");
		//Vector3 PlayerPos = Player.transform.position;
		transform.position = Player.transform.position;
		bulletDirection = Player.transform.up;
		bulletRigidBody = GetComponent<Rigidbody2D> ();
		Destroy (gameObject, bulletLifeSpan);
	}
	


	void FixedUpdate () {
		bulletRigidBody.velocity = bulletDirection * BulletSpeed;


	}
}
