using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

	public int health;
	public GameObject explosionEffect;
	public GameObject[] hearts;


	void Start()
	{
		ShowHearts();
	}

	public void IncrementHealth(int damage) {
		health += damage;
		if (health <= 0) {
			Destroy (gameObject);
			Instantiate (explosionEffect, transform.position, Quaternion.identity);
		}
		ShowHearts();
	}

	private void ShowHearts()
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




}
