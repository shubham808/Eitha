using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour {
	private int i = -1;
	private int x = 0 ;
	public GameObject wall;
	void Update(){
		Debug.Log (PlayerPrefs.GetInt ("mode"));
	}
	// Use this for initialization
	void Start () {
		if(PlayerPrefs.GetInt("mode") == 1)
			InvokeRepeating ("Create",.12f,.32f);

		if(PlayerPrefs.GetInt("mode") == 2)
			InvokeRepeating ("Create",.12f,.32f);
		
	}
	
	// Update is called once per frame
	void Create () {
		GameObject next = (GameObject)Instantiate (wall);
		 
		SpriteRenderer renderer = next.GetComponent<SpriteRenderer> ();

		x = nextCol ();
		if(x==0)
			renderer.material.color= new Color(68f/256f,137f/256f,200f/256f) ;
		if(x==1)
			renderer.material.color = new Color(237f/256f,26f/256f,125f/256f) ;
		if(x==2)
			renderer.material.color = new Color(46f/256f,40f/256f,64f/256f) ;
		if(x==3)
			renderer.material.color = new Color(205f/256f,204f/256f,204f/256f) ;
	
	}
	int nextCol(){

		if (PlayerPrefs.GetInt ("mode") == 1)
			return Random.Range(0,4);
		int[] a = new int[]{2,2,3,3,4,2,2,3,2,3,3,2,3,4,3,3,2,2,3,2,4,3,2,1,2,3,2,1,1,
			2,2,3,2,3,2,3,4,3,4,3,4,4,2,2,3,2,3,3,2,3,3,2,3,2,1,3,2,3,2,2,3,2,3,3,2,1,2,1,2,
			1,2,2,3,2,3,2,2,3,2,4,3,2,2,3,2,3,3,2,3,2,2,4,2,1,2,2,1,3,2,2,3,3,2,1,1,2,3,1,2,
			2,3,2,4,3,3,2,3,2,2,2,4,2,4,2,1,1,4,2,1,3,2,2,3,2,4,3,3,2,2,2,3,2,3,3,2,2,2,1,2,
			1,2,3,2,2,4,3,4,3,3,2,2,2,3,3,2,1,1,1,1,3,3,4,4,3,4,4,4,4,4,4,4,3,3,3,3,3,4,3,3,
			2,1,1,1,2,3,2,3,3,2,3,4,3,3,2,3,4,4,3,3,2,1,1,2,2,2,3,2,3,3,2,3,2,3,2,1,1,1,2,2,
			2,3,2,2,2,3,2,3,4,3,4,4,3,4,3,3,3,3,4,3,3,3,3,2,3,2,4,4,2,1,2,2,1,2,2,2,2,2,2,2,
			2,2,1,3,2,3,4,3,1,3,3,2,3,3,2,3,3,4,3,4,4,3,2,2,3,3,2,3,4,3,3,3,1,3,3,3,3,2,1,3,
			4,3,3,3,1,3,2,4,4,1,3,2,1,4,4,3,2,3,3,4,3,3,3,2,4,3,4,4,2,4,3,4,3,3,3,3,3,2,3,2,
			2,2,2,2,1,2,2,2,3,2,2,3,2,3,3,2,3};
		i++;i %= a.Length;
		return (a[i]-1);
	}
}
