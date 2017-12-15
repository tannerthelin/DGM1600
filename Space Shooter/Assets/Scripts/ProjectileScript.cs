using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour {

	public double lifetime;
	public int damage;
	//public AudioSource audio;

	// Update is called once per frame
	void Update () {
		lifetime -= Time.deltaTime;
		if (lifetime <= 0){
			Destroy (gameObject);
		}

	}

	void Start()
	{
		//audio.pitch = Random.Range(1f, 1.5f);
	}


	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.GetComponent<Meteor>())
		{
			other.GetComponent<Meteor>().meteorHealth--;
			Destroy(gameObject);
		}
	}


//	void OnCollisionEnter2D (){
//		Destroy(gameObject);
//	}



}
