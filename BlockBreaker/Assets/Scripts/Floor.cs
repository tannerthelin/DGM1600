﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour {

	public LevelManager myLevelManager;



	void OnTriggerEnter2D (Collider2D myCollider) {
		myLevelManager.LevelLoad ("Game Over");
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
