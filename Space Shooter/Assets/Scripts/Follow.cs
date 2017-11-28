using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {

	public Transform objectToFollow;
	public float zOffset;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 myPos = objectToFollow.position; // create myPos, follow object.position

		myPos.z = zOffset; // change z to zOffset

		gameObject.transform.position = myPos;
	}
}
