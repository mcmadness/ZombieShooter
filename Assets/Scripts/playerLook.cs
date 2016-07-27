
using UnityEngine;
using System.Collections;

public class playerLook : MonoBehaviour {
	public GameObject Player ;



	void Update () {

		Vector3 cursorPositionInWorld = Camera.main.ScreenToWorldPoint (Input.mousePosition);

		cursorPositionInWorld.z = 0f ;

		Player.transform.up = cursorPositionInWorld - Player.transform.position;

	}
}
