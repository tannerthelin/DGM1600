using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour {

	public float startRotation;
	public GameObject[] smallMeteors;
	public Transform meteorPos;

	//Start
	void Start() {
		GetComponent<Rigidbody2D>().AddTorque(Random.Range(-startRotation, startRotation), ForceMode2D.Impulse);
	}


	void OnCollisionEnter2D(Collision2D coll)
	{
		coll.gameObject.GetComponent<Health>().IncrementHealth(-1);
	}
		
}
