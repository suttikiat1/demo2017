﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ceil : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "Ball") 
			Destroy (collision.gameObject);

	}
}
