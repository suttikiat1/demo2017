using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Sceneball : MonoBehaviour {
	public Text txtScore;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	int score = 0;
	public void Push1(){
		score++;
		txtScore.text = "Score :" + score.ToString ();
	}


	public void Dochange (){
		SceneManager.LoadScene (0);
	}
}
