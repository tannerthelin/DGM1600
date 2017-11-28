using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour {

	public double lifetime;

	// Update is called once per frame
	void Update () {
		//transform.Translate (Vector3.up * speed * Time.deltaTime);

		lifetime -= Time.deltaTime;
		if (lifetime <= 0){
			Destroy (gameObject);
		}
	}

	void OnCollisionEnter2D (){
		Destroy(gameObject);
	}




}
