using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryScript : MonoBehaviour {

	public Text textObject;

	public enum States {start, forest, cave, shore_0};
	public States myState;


	// Use this for initialization
	void Start () {
		myState = States.start;
	}
	
	// Update is called once per frame
	void Update () {
		if (myState == States.start) {State_start ();} 
		else if (myState == States.forest) {State_forest ();}
		else if (myState == States.cave) {State_cave ();}
	}


	void State_start () {
		textObject.text = "You are on a small desert island." +
		"\n There is a FOREST with trees. " +
		"\n There is also a CAVE." +
		"\n\n Press F to go to FOREST. Press C to go to CAVE.";

		if (Input.GetKeyDown (KeyCode.F)) {myState = States.forest;}
		else if (Input.GetKeyDown (KeyCode.C)) {myState = States.cave;}
	}

	void State_forest () {
		textObject.text = "Forest State";

		if (Input.GetKeyDown (KeyCode.C)) {myState = States.cave;}
	}

	void State_cave () {
		textObject.text = "Cave State";

		if (Input.GetKeyDown (KeyCode.F)) {myState = States.forest;}
	}

}
