using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {



	void Start () {

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

}
