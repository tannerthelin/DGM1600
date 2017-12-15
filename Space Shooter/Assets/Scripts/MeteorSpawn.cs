using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawn : MonoBehaviour {

	public GameObject asteroids;


	void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.red;
	}

	void Start()

	{
		Vector3 position = new Vector3(Random.Range(-50.0f, 50.0f), 0, Random.Range(-70.0f, 70.0f));
		Instantiate(asteroids, position, Quaternion.identity);
	}	


}
