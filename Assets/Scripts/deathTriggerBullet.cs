using UnityEngine;
using System.Collections;

public class deathTriggerBullet : MonoBehaviour {
	public int damage = 5 ;
	// a function that is automatically called when something with a rigidbody2d enters this trigger


	void OnTriggerEnter2D (Collider2D activator) {
		if (activator.tag != "Player") {
			if ((activator.GetComponent<killable> () != null) ) {
				//TODO subtract health
				activator.GetComponent<killable> ().Hurt (damage);


			}
		}

	}
	void OnTriggerStay2D (Collider2D activator) {
		if (activator.tag != "Player") {
			if ((activator.GetComponent<killable> () != null)) {
				//TODO subtract health
				activator.GetComponent<killable> ().Hurt (damage);
				Destroy(gameObject) ;
			}
		}

	}
}
