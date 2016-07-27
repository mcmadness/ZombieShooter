using UnityEngine;
using System.Collections;

public class deathTriggerZombie : MonoBehaviour {
	public int damage = 1 ;
	// a function that is automatically called when something with a rigidbody2d enters this trigger


	void OnTriggerEnter2D (Collider2D activator) {
		if (activator.tag != "Zombie") {
			if ((activator.GetComponent<killable> () != null)) {
				//TODO subtract health
				activator.GetComponent<killable> ().Hurt (damage);
				//destroy this object
				//	Destroy(activator.gameObject ) ;

			}
		}

	}
	void OnTriggerStay2D (Collider2D activator) {
		if (activator.tag != "Zombie") {
			if ((activator.GetComponent<killable> () != null)) {
				//TODO subtract health
				activator.GetComponent<killable> ().Hurt (damage);
				//destroy this object
				//	Destroy(activator.gameObject ) ;

			}
		}

	}

}
