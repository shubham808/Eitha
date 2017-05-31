using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Start_menu : MonoBehaviour {




	public Canvas quitmenu;
	public Button starttext;
	public Button exittext;
	public GameObject c1, c2, hint;
	// Use this for initialization
	void Start () {
		

		quitmenu = quitmenu.GetComponent<Canvas> ();
		starttext = starttext.GetComponent<Button> ();
		exittext = exittext.GetComponent<Button> ();
		quitmenu.enabled = false;
	}
	
	// Update is called once per frame
	public void ExitPress(){
		
		quitmenu.enabled = true;
		starttext.enabled = false;
		exittext.enabled = false;
	}

	public void NoPress(){


		quitmenu.enabled = false;
		starttext.enabled = true;
		exittext.enabled = true;
	}

	public void StartLevel(){
		
		Time.timeScale = 1;
		PlayerPrefs.SetInt ("mode",1);

		SceneManager.LoadScene (1);
	}

	public void fastmode(){
		Time.timeScale = 1;
		PlayerPrefs.SetInt ("mode",2);
		SceneManager.LoadScene (1);
	}

	public void ExitGame(){
		Application.Quit ();		
	}
	public void helpon(){
		c1.SetActive (false);
		c2.SetActive (false);
		hint.SetActive (true);
	}
	public void helpoff(){
		c1.SetActive (!false);
		c2.SetActive (!false);
		hint.SetActive (!true);
	}
}
