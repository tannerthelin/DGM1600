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

	//Update
	void Update() {

	}

	void OnCollisionEnter(Collision c)
	{
		Instantiate(smallMeteors[1], c.gameObject.transform.position, c.gameObject.transform.rotation);

		//Destroy(gameObject);
	}
		
}
