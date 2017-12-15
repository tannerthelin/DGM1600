using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour {

	public int health;
	public GameObject explosionEffect;
	public GameObject[] hearts;
	public GameObject player;
	public LevelManager myLevelManager;

	void Start()
	{
		ShowHearts();
	}


	public void IncrementHealth(int damage) {
		health += damage;
		if (health <= 0) {
			Die();
			SceneManager.LoadScene ("Game Over");
		}
        ShowHearts();
	}

	public void ShowHearts()
	{
		// Turn off all the hearts
		for (int h = 0; h < hearts.Length; h++)
		{
			hearts[h].SetActive(false);
		}

		// Turn hearts on by health
		for(int i = 0; i < health; i++)
        {
			hearts[i].SetActive(true);
        }	
	}

	// a function that DOES have a return
	public int GetHealth()
	{
		//fun code

		return health;
	}

	public void Die()
	{
		Destroy(player);
		Instantiate(explosionEffect, transform.position, Quaternion.identity);
	}


}
