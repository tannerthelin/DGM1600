using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp_Script : MonoBehaviour {

	public enum Type {fancyLaser, overSheild, speedBoosterGoWayFast};
	public Type powerupType;
	public Sprite[] images;



	// Use this for initialization
	void Start () {
		switch (powerupType) {
		case Type.fancyLaser:
			gameObject.GetComponent <SpriteRenderer>().sprite = images[0];
			break;

		case Type.overSheild:
			gameObject.GetComponent <SpriteRenderer>().sprite = images[1];
			break;

		case Type.speedBoosterGoWayFast:
			gameObject.GetComponent <SpriteRenderer>().sprite = images[2];
			break;
		}
	}

	bool AmPlayer()
	{
		if (GetComponent<PlayerController>())
		{
			return true;
		}
		else { return false;}
	}

	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D other) {

		if (other.GetComponent<PlayerController>())
		{

			switch (powerupType)
			{

				case Type.speedBoosterGoWayFast:
					other.GetComponent<PlayerController>().speed *= 2;
					break;

				case Type.fancyLaser:
					//Stuff Goes Here
					break;

				case Type.overSheild:
					other.GetComponent<Health>().health += 1;
					other.GetComponent<Health>().ShowHearts();
					break;
			}


			Destroy(this.gameObject);
		}
	}



}
