using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryScript : MonoBehaviour {

	public Text textObject;

	public enum States {start, forest, forest_0, forest_1, cave, cave_0, shore, shore_0, ocean, knife, monster_0, monster_1, flare, flare_0, win};
	public States myState;


	// Use this for initialization
	void Start () {
		myState = States.start;
	}
	
	// Update is called once per frame
	void Update () {
		if (myState == States.start) {State_start ();} 
		else if (myState == States.forest) {State_forest ();}
		else if (myState == States.forest_0) {State_forest_0 ();}
		else if (myState == States.forest_1) {State_forest_1 ();}
		else if (myState == States.cave) {State_cave ();}
		else if (myState == States.cave_0) {State_cave_0 ();}
		else if (myState == States.shore) {State_shore ();}
		else if (myState == States.shore_0) {State_shore_0 ();}
		else if (myState == States.ocean) {State_ocean ();}
		else if (myState == States.knife) {State_knife ();}
		else if (myState == States.monster_0) {State_monster_0 ();}
		else if (myState == States.monster_1) {State_monster_1 ();}
		else if (myState == States.flare) {State_flare ();}
		else if (myState == States.flare_0) {State_flare_0 ();}
		else if (myState == States.win) {State_win ();}
	}


	void State_start () {
		textObject.text = "You are on a small desert island." +
		"\nThere is a FOREST with trees. " +
		"\nThere is also a SHORE." +
		"\n\nPress F to go to FOREST. Press S to go to SHORE.";

		if (Input.GetKeyDown (KeyCode.F)) {myState = States.forest;}
		else if (Input.GetKeyDown (KeyCode.S)) {myState = States.shore;}
	}




	// Here are the main functions

	void State_forest () {
		textObject.text = "You walk into a beautiful forest of pine trees." +
			"\nUp ahead, you see a cave. It looks like something might be living inside..." +
			"\n\nPress C to go into the cave, press S to go to SHORE.";

		if (Input.GetKeyDown (KeyCode.C)) {myState = States.cave;}
		if (Input.GetKeyDown (KeyCode.S)) {myState = States.shore;}
	}
		

	void State_cave () {
		textObject.text = "You venture into the dark cave. It's very quiet." +
			"\nA huge, disgusting MONSTER lumbers out of the shadows." +
			"\nIt roars and begins to walk towards you." +
			"\n\nPress F to run back to the FOREST, press M to fight the MONSTER.";

		if (Input.GetKeyDown (KeyCode.F)) {myState = States.forest;}
		if (Input.GetKeyDown (KeyCode.M)) {myState = States.monster_0;}
	}


	void State_shore () {
		textObject.text = "You walk out onto a beautiful shore." +
			"\nThe ocean goes as far as the eye can see." +
			"\nWaves softly crash against the shore." +
			"\n\nPress O to swim in the OCEAN, press F to go back to the FOREST.";

		if (Input.GetKeyDown (KeyCode.F)) {myState = States.forest;}
		if (Input.GetKeyDown (KeyCode.O)) {myState = States.ocean;}
	}


	void State_shore_0 () {
		textObject.text = "You swim back to the shore." +
			"\n\nPress F to go back to the FOREST.";

		if (Input.GetKeyDown (KeyCode.F)) {myState = States.forest_1;}
	}

	void State_forest_1 () {
		textObject.text = "You walk into a beautiful forest of pine trees." +
			"\nUp ahead, you see a cave. It looks like something might be living inside..." +
			"\n\nPress C to go into the cave, press S to go to the SHORE.";

		if (Input.GetKeyDown (KeyCode.C)) {myState = States.cave_0;}
		if (Input.GetKeyDown (KeyCode.S)) {myState = States.shore;}
	}


	void State_cave_0 () {
		textObject.text = "You venture into the dark cave. It's very quiet." +
			"\nA huge, disgusting MONSTER lumbers out of the shadows." +
			"\nIt roars and begins to walk towards you." +
			"\n\nPress F to run back to the FOREST, press M to fight the MONSTER.";

		if (Input.GetKeyDown (KeyCode.F)) {myState = States.forest_1;}
		if (Input.GetKeyDown (KeyCode.M)) {myState = States.monster_1;}
	}
		


	void State_ocean () {
		textObject.text = "You wade into the ocean and swim past the dropoff." +
			"\nYou can see huge schools of fish below you." +
			"\nYour eye catches the glimmer of a KNIFE on the ocean floor." +
			"\n\nPress K to grab the KNIFE, press S to go back to the SHORE.";

		if (Input.GetKeyDown (KeyCode.S)) {myState = States.shore_0;}
		if (Input.GetKeyDown (KeyCode.K)) {myState = States.knife;}
	}


	void State_knife () {
		textObject.text = "You swim down to the bottom and grab the knife from the sand." +
			"\nIt's rusty, but still sharp enough to be used." +
			"\n\nPress S to go back to the SHORE.";

		if (Input.GetKeyDown (KeyCode.S)) {myState = States.shore_0;}
	}


	void State_monster_0 () {
		textObject.text = "YOU DIED." +
			"\nYou didn't stand a chance." +
			"\nThe monster eats you in one bite." +
			"\n\nPress R to RESTART the game.";

		if (Input.GetKeyDown (KeyCode.R)) {myState = States.start;}
	}


	void State_monster_1 () {
		textObject.text = "As the MONSTER approaches you, you pull out your KNIFE." +
			"\nIt lunges at you and you stab it in the heart wiht your KNIFE." +
			"\nThe MONSTER falls onto the ground, DEAD." +
			"\nBehind the MONSTER's body, you notice a dusty FLARE partially buried." +
			"\n\nPress F to get the FLARE.";

		if (Input.GetKeyDown (KeyCode.F)) {myState = States.flare;}
	}


	void State_flare () {
		textObject.text = "You pick up the FLARE." +
			"\nIt looks like it still works." +
			"\nMaybe you can use it to get help." +
			"\n\nPress S to shoot the FLARE, press F to go back to the FOREST.";

		if (Input.GetKeyDown (KeyCode.F)) {myState = States.forest_0;}
		if (Input.GetKeyDown (KeyCode.S)) {myState = States.flare_0;}
	}


	void State_flare_0 () {
		textObject.text = "You shot the flare inside the cave." +
			"\nThe ceiling starts to crumble and the cave collapses." +
			"\nYou're an idiot." +
			"\nYOU DIED." +
			"\n\nPress R to RESTART the game.";

		if (Input.GetKeyDown (KeyCode.R)) {myState = States.start;}
	}


	void State_forest_0 () {
		textObject.text = "You step back into the FOREST." +
			"\n\nPress S to shoot the FLARE.";

		if (Input.GetKeyDown (KeyCode.S)) {myState = States.win;}
	}


	void State_win () {
		textObject.text = "A nearby plane sees you and calls for help." +
			"\nIn a few hours, a helicopter arrives to pick you up." +
			"YOU WIN.";
	}
}
