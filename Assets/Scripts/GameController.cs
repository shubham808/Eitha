using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	private int score;
	private int hiscore = 0;
	bool ismute = false;
	public Text stext;
	public Text histext;
	public Text fhiscore;
	public Text ptext;

	public void Inc_score(){
		score+=10;
		stext.text =""+ score;
	}

	public void mute(){
		ismute = !ismute;
		AudioListener.volume = ismute ? 0 : 1;
	}

	public void Dec_score(){
		score-=2;
		stext.text = ""+score;
	}

	public void Pause(){
		ptext.text = "" + score;
		Time.timeScale = 0;
	}

	public void Play(){

		Time.timeScale = 1;
	}

	public void GameOver(){
		
		if (score > PlayerPrefs.GetInt("hiscore")&&PlayerPrefs.GetInt("mode")==1) {
			PlayerPrefs.SetInt ("hiscore",score);
		}
		if (score > PlayerPrefs.GetInt("fhiscore")&&PlayerPrefs.GetInt("mode")==2) {
			PlayerPrefs.SetInt ("fhiscore",score);
		}
		PlayerPrefs.SetInt ("score",score);
		faded ();
		SceneManager.LoadScene (2);
	}

	public IEnumerator faded(){
		float fadetime = GetComponent<fade> ()
			.BeginFade (-1);
		yield return new WaitForSeconds(fadetime);
	}
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
