using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Pause_game : MonoBehaviour {



	public Canvas paused;
	public GameObject gamecontrollerobject,scoretext,yourtext,hint,pausedtxt,psdbutton,camera;
	private GameController gamectrl;
	// Use this for initialization
	void Start () {
		
		gamecontrollerobject = 
			GameObject.FindWithTag ("GameController");

		gamectrl = 
			gamecontrollerobject.GetComponent <GameController> ();
		
		paused = paused.GetComponent<Canvas> ();
		paused.enabled = false;
	}
	
	// Update is called once per frame
	public void pause(){
		
		paused.enabled = true;
		gamectrl.Pause ();
		psdbutton.SetActive (false);
		camera.GetComponent<AudioSource> ().Pause();
	}
		

	public void play(){
		
		paused.enabled = false;
		gamectrl.Play ();
		psdbutton.SetActive (true);
		camera.GetComponent<AudioSource> ().UnPause();
	}
	public void home(){
		
		gamectrl.faded ();
		SceneManager.LoadScene (0);
	}
	public void help(){
		scoretext.SetActive (false);
		yourtext.SetActive (false);
		hint.SetActive (true);
		Debug.Log ("haha");
		pausedtxt.SetActive (false);
	}
	public void offhint(){
		scoretext.SetActive (true);
		yourtext.SetActive (true);
		hint.SetActive (false);
		pausedtxt.SetActive (true);
		Debug.Log ("lol");
	}
}
