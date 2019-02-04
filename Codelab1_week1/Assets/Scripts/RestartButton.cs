using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartButton : MonoBehaviour
{
	private GameObject timecon;

	private GameObject button;
	// Use this for initialization
	void Start ()
	{
		timecon = GameObject.Find("TimerController");
		button = GameObject.Find("Restart");
	}
	
	// Update is called once per frame
	void Update () {
		
		Debug.Log(timecon.GetComponent<CountdownScript>().gameOver); 
			if(timecon.GetComponent<CountdownScript>().gameOver)  //the button only shows up when game is over
		{
			button.SetActive(true); 
		}
			else
			{
				button.SetActive(false); 
			}
		
		
	}
}
