using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreboardScript : MonoBehaviour
{

	public static int score;
	public Text highscoreDisplay;
	public Text display;


	void Start()
	{
		// Reset the score.
		score = 10;

		if (display != null)
			display.text = "Meteors Left: " + score.ToString();

		//if (highscoreDisplay != null)
		//	highscoreDisplay.text = GetScore().ToString();

	}

	void Update() 
	{
		if (score <= 0)
		{
			SceneManager.LoadScene ("You Win");
		}
	}

	public void IncrementScoreboard()
	{
		score -= 1;
		display.text = "Meteors Left: " + score.ToString();
	}

	 public void SaveScore() 
	{
		//check previous score
		int oldScore = GetScore();

		if (score > oldScore)
		{
			PlayerPrefs.SetInt("HighsScore", score);
		}
	}

	public int GetScore()
	{
		return PlayerPrefs.GetInt ("Highscore");
	}

	public void OnDisable()
	{
		SaveScore();
	} 

}
