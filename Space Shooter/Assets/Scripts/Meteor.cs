using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Meteor : MonoBehaviour {

	public float startRotation;
	public float startThrust;
	public GameObject[] smallMeteors;
	public Transform meteorPos;
	public Rigidbody2D rb;
	public int meteorHealth = 1;
	public GameObject explosionEffect;
	private GameObject scoreboard;
	private Vector2 randomVector;

	//Start
	void Start() {
		rb = GetComponent<Rigidbody2D>();
		randomVector = new Vector2(Random.Range(-10, 10), Random.Range(-10, 10));

		rb.AddTorque(Random.Range(-startRotation, startRotation), ForceMode2D.Impulse);
		rb.AddForce(randomVector * startThrust);
		scoreboard = FindObjectOfType<ScoreboardScript>().gameObject;
	}


	void OnCollisionEnter2D(Collision2D coll)
	{
		if (IsThisMeteor())
		{
			meteorHealth = 1;
		}
		else { meteorHealth--;}
	}

	void Update()
	{
		if (meteorHealth <= 0)
		{
			scoreboard.GetComponent<ScoreboardScript>().IncrementScoreboard();
			Instantiate(explosionEffect, transform.position, Quaternion.identity);
			Destroy(gameObject);
		}
	}

	bool IsThisMeteor()
	{
		if (GetComponent<Meteor>())
		{
			return true;
		}
		else
		{ return false;}
	}
		
}
