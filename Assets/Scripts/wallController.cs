using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallController : MonoBehaviour {

	public Vector2 velocity = new Vector2 (0f,-3f);
	public Vector2 speed = new Vector2 (0f,-5f);
	// Use this for initialization
	void Start () {

		if (PlayerPrefs.GetInt ("mode") == 1) {
			GetComponent<Rigidbody2D> ()
			.velocity = velocity;

			GetComponent<Rigidbody2D> ()
			.gravityScale = 0;
		}

		if (PlayerPrefs.GetInt ("mode") == 2) {
			GetComponent<Rigidbody2D> ()
			.velocity = speed;

			GetComponent<Rigidbody2D> ()
			.gravityScale = 0;
		}
	}

}
