using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

	// Player movement
	public float speed = 1.0f;
	public float rotSpeed = 1.0f;
	private Rigidbody2D rigid;

	// Laser Shots
	public GameObject projectile;
	public Transform shotPos;
	public float shotForce;
	public ParticleSystem particles;

	void Die()
	{
		Destroy(gameObject);
	}


	void Start()
	{

		rigid = this.GetComponent<Rigidbody2D>();

	}

	// Update is called once per frame
	void Update()
	{

		if (Input.GetKey(KeyCode.UpArrow))
		{
			rigid.AddForce(transform.up * speed);
			particles.Emit(1);
		}

		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Rotate(Vector3.forward, rotSpeed * Time.deltaTime);
		}

		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.Rotate(Vector3.forward, -rotSpeed * Time.deltaTime);
		}


		if (Input.GetKeyDown(KeyCode.Space))
		{
			GameObject shot = Instantiate(projectile, shotPos.position, shotPos.rotation) as GameObject;
			shot.GetComponent<Rigidbody2D>().AddForce(shotPos.up * shotForce);


		}
	}
}
