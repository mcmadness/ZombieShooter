using UnityEngine;
using System.Collections;

public class playerMove : MonoBehaviour {

	Vector2 moveVector ;
	Rigidbody2D myRigidBody ;
	// Use this for initialization

	public float playerSpeed = .1f;
	public GameObject bullet ;


	void Start () {
		myRigidBody = GetComponent<Rigidbody2D> ();

	}

	void Update () {
		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");
		moveVector = new Vector2 (horizontal, vertical);


		if (moveVector.magnitude > 1f) {
			moveVector = moveVector.normalized; 
		}

		if (Input.GetMouseButtonDown (0)) {
			Instantiate (bullet);

		}
	}

	void FixedUpdate (){
		
		myRigidBody.velocity = moveVector * playerSpeed;


	}
}
