using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class game_over : MonoBehaviour {

	public Canvas over;
	private int score;
	private int hiscore;
	private int fhiscore;
	public GameObject gamecontrollerobject;
	private GameController faded;
	public Text stext;
	public Text histext;
	public Text fhistext;
	private float fadetime;
	// Use this for initialization
	void Start () {

		gamecontrollerobject = 
			GameObject.FindWithTag ("GameController");


		score = PlayerPrefs.GetInt ("score");
		hiscore = PlayerPrefs.GetInt ("hiscore");
		fhiscore = PlayerPrefs.GetInt ("fhiscore");
		stext.text = "Score: "+score;
		fhistext.text = "Fast Mode Hi-score: " + fhiscore;
		histext.text = "Normal Mode Hi-score: "+hiscore;
	}

	// Update is called once per frame

	public void again(){
		SceneManager.LoadScene (1);	
	}
	public void home(){
		SceneManager.LoadScene (0);
	}
}
