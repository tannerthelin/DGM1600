using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

	// Player movement
	public float speed = 1.0f;
	private Rigidbody2D rigid;
	public int health;

	// Laser Shots
	public GameObject projectile;
	public Transform shotPos;
	public float shotForce;
	public ParticleSystem particles;

	// Use this for initialization
	void Start () {
		
		rigid = this.GetComponent<Rigidbody2D> ();
	
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.LeftArrow)) {
			rigid.velocity	= new Vector3 (-speed, 0, 0);
		} 

		if (Input.GetKey(KeyCode.RightArrow))
		{
			rigid.velocity	= new Vector3(speed, 0, 0);
		}

		if (Input.GetKey(KeyCode.UpArrow))
		{
			rigid.velocity	= new Vector3(0, speed, 0);
			particles.Emit (1);
		} 
		else { particles.Stop (); }

		if (Input.GetKey(KeyCode.DownArrow))
		{
			rigid.velocity	= new Vector3(0, -speed, 0);
		}

		if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.UpArrow))
		{
			rigid.velocity	= new Vector3(-speed, speed, 0);
		}

		if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.UpArrow))
		{
			rigid.velocity	= new Vector3(speed, speed, 0);
		}

			if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.DownArrow))
		{
			rigid.velocity	= new Vector3(-speed, -speed, 0);
		}

				if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.DownArrow))
		{
			rigid.velocity	= new Vector3(speed, -speed, 0);
		} 



		if(Input.GetKeyDown(KeyCode.Space))
		{
			GameObject shot = Instantiate(projectile, shotPos.position, shotPos.rotation) as GameObject;
			shot.GetComponent<Rigidbody2D>().AddForce(shotPos.up * shotForce);
		}


		switch (health) {
		case 1: // do this stuff; break;
			break;
		}

	}
}
