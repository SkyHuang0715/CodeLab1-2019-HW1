using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class Spawner : MonoBehaviour {

	private bool gameOver;
	// Use this for initialization
	void Start () {
		gameOver = false;
		//Spawn();
		InvokeRepeating("SpawnRed",3,3);
		InvokeRepeating("SpawnBlue",3,3);
		//InvokeRepeating("Spawn",3,3);
	}
	
	// Update is called once per frame
	void Update () {
	
		if (!gameOver)
		{
			//Spawn();
			
			
		}
	}

	void SpawnRed ()
	{
		GameObject newPrize = Instantiate(Resources.Load<GameObject>("Prefab/Prize"));
		newPrize.transform.position = new Vector2(Random.Range(-10,10), Random.Range(-5,5));





	}

	void SpawnBlue()
	{
		GameObject newPrize1 = Instantiate(Resources.Load<GameObject>("Prefab/blueprize"));
		newPrize1.transform.position = new Vector2(Random.Range(-10,10), Random.Range(-5,5));
	}
	
	
	
}
