﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public void ExitGame (){
		print ("Tried to Exit.");
		Application.Quit ();
	}

}
