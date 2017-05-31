using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fade : MonoBehaviour {

	public Texture2D fadeouttexture;
	public float fadespeed;

	int drawdepth = -1000;
	float alpha = 1.0f;
	int fadedir = -1;

	void OnEnable(){

		SceneManager.sceneLoaded += onSceneLoaded;
	}

	void OnGUI(){

		alpha += fadedir * fadespeed * Time.deltaTime;
		alpha = Mathf.Clamp01 (alpha);
		GUI.color = new Color (GUI.color.r,GUI.color.g ,GUI.color.b,alpha);
		GUI.depth = drawdepth;
		GUI.DrawTexture (new Rect(0,0,Screen.width,Screen.height),fadeouttexture);
	}

	public float BeginFade (int dir){
		fadedir = dir;
		return fadespeed;
	}

	void onSceneLoaded(Scene previousScene, LoadSceneMode loadSceneMode){
		BeginFade (-1);
	}
}
