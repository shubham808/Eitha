using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletController : MonoBehaviour {

	private GameController gamectrl;

	void Start () {
		GameObject gamecontrollerobject = 
			GameObject.FindWithTag ("GameController");

		gamectrl = 
			gamecontrollerobject.GetComponent <GameController> ();
	}
	
	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D c) {
		if (c.gameObject.tag.Equals ("wall")) {

			SpriteRenderer bullet_ren = gameObject.GetComponent<SpriteRenderer> ();
			SpriteRenderer wall_ren = c.gameObject.GetComponent<SpriteRenderer> ();

			if (bullet_ren.material.color == wall_ren.material.color) {
				gamectrl.Inc_score ();
				Destroy (c.gameObject);	
			} else {
				gamectrl.Dec_score ();
			}
			Destroy (gameObject);
		}

	}
}
