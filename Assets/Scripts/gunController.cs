using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunController : MonoBehaviour {

	public GameObject bullet;
	private GameController gamectrl;
	// Use this for initialization
	void Start () {
		GameObject gamecontrollerobject = 
			GameObject.FindWithTag ("GameController");

		gamectrl = 
			gamecontrollerobject.GetComponent <GameController> ();
		
	}

	void OnCollisionEnter2D (Collision2D c) {
			gamectrl.GameOver ();
	}

	void OnMouseEnter(){
		
		if(Input.GetTouch(0).phase == TouchPhase.Began)
		InvokeRepeating ("create",0.0f,0.15f);

		if (Input.GetTouch (0).phase == TouchPhase.Ended)
			CancelInvoke ("create");
		}

	void OnMouseExit(){
		CancelInvoke ("create");
	}
	public void create(){
		if (Time.timeScale == 0)
			return;
		if(Input.GetTouch (0).phase == TouchPhase.Ended){
			CancelInvoke ("create");
		}
		GameObject next =  Instantiate (bullet,
			new Vector3(transform.position.x,transform.position.y + 1.5f,0f),
			Quaternion.identity);

		TrailRenderer trail = 
			next.GetComponent<TrailRenderer> ();
		SpriteRenderer renderer = 
			next.GetComponent<SpriteRenderer> ();
		trail.sortingLayerName = "Character";
		trail.sortingOrder = 2;
		if (gameObject.tag == "0") {
			renderer.material.color = new Color(237f/256f,26f/256f,125f/256f);

			trail.material.color =new Color(237f/256f,26f/256f,125f/256f);

		}
		if (gameObject.tag == "1") {
			renderer.material.color =new Color(205f/256f,204f/256f,204f/256f) ;
			trail.material.color = new Color(205f/256f,204f/256f,204f/256f) ;
		}	
		if (gameObject.tag == "2") {
			renderer.material.color = new Color(46f/256f,40f/256f,64f/256f) ;
			trail.material.color = new Color(46f/256f,40f/256f,64f/256f) ;
		}
		if (gameObject.tag == "3") {
			renderer.material.color = new Color(68f/256f,137f/256f,200f/256f);
			trail.material.color = new Color(68f/256f,137f/256f,200f/256f);
		}
	}
}
