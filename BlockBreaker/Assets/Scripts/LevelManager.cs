using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {


	public static int brickCount;

	void Start () {
		brickCount = FindObjectsOfType<BrickManager> ().Length;
		print (brickCount);
	}

	public void ExitGame (){
		print ("Tried to Exit.");
		Application.Quit ();
	}

	public void LevelLoad (string name) {
		SceneManager.LoadScene (name);
	}

	// Get the current scene and load the next one in the Build Index
	public void LoadNextLevel () {
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void CheckBrickCount () {
		if (brickCount <= 0) {
			LoadNextLevel ();
		}
	}
}
