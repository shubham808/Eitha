using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scratchpad : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	public IEnumerator fade(){
		float fadetime = GetComponent<fade> ()
			.BeginFade (1);
		yield return new WaitForSeconds(fadetime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
