using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scaler : MonoBehaviour {

	// Use this for initialization

	void Start () {
		float targetwidth = 600.0f;
		float targetheight = 1024.0f;
		int pxltounit = 30;

		float ratio = targetwidth / targetheight;
		float current = (float)Screen.width / (float)Screen.height;

		if (current >= ratio) {
			Camera.main.orthographicSize = targetheight / 4 / pxltounit;

		} else {
			float diff = ratio / current;
			Camera.main.orthographicSize = targetheight / 4 / pxltounit*diff;
		}
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
