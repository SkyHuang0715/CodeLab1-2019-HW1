using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blueprizeScript : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.name == "player1") //if the collider attached the prize
		{
			other.gameObject.GetComponent<PlayerController>().score--; //Get the PlayerController and lose 1 score
			{

			}
		}

		if (other.gameObject.name == "player2") //if the collider attached the prize
		{
			other.gameObject.GetComponent<PlayerController>().score++; //Get the PlayerController and add 1 score
			{

			}
		}

		//print("I GOT HIT");
		if (other.gameObject.CompareTag("Player"))
		{
			Destroy(gameObject); //Destroy the gameObject I am attached to
		}
	}
}