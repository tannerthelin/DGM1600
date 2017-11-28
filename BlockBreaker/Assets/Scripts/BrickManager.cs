using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrickManager : MonoBehaviour {
		
	public int BrickHealth = 2;
	public Sprite[] brickStates;
	public int spriteCounter = 0;
	private LevelManager levelManager;


	void Start () {
		levelManager = FindObjectOfType<LevelManager> ();
	}

	void OnCollisionEnter2D(Collision2D collisionInfo) {

		// Take away health
		BrickHealth--;
		spriteCounter++;

		if (BrickHealth > 0) {
			GetComponent<SpriteRenderer> ().sprite = brickStates [spriteCounter];
		}
		// Destroy Brick
		else if (BrickHealth <= 0) {
			LevelManager.brickCount--;
			levelManager.CheckBrickCount ();
			Destroy(gameObject);
		}


	}
}