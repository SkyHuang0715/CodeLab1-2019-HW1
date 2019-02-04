using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class CountdownScript : MonoBehaviour 
{
	
	[SerializeField] private Text uiText;
	[SerializeField] private float mainTimer;

	private float timer;
	private bool canCount = true;
	private bool doOnce = false;

	public bool gameOver;
	public Button Restart;

	void Start()
	{
		
		gameOver = false;
		timer = mainTimer;
		
	}
	void Update()
	{
		if (timer >= 0.0f && canCount)
		{
			
			timer -= Time.deltaTime;
			uiText.text = timer.ToString("F");
			
		}
		else if(timer <= 0.0f && !doOnce)
		{
			canCount = false;
			doOnce = true;
			uiText.text = "0.00";
			timer = 0.0f;
			GameOver();
		
			

		}
	}

	public void Resetbtn()
	{
		if (!gameOver)
		{
			//gameObject.SetActive(false); 
			Restart.interactable = !Restart.interactable;
		}

		
		timer = mainTimer;
		canCount = true;
		doOnce = false;
		
		SceneManager.LoadScene(0);  
		
		Time.timeScale = 1; 

	}
	
	

	void GameOver()
	{
		Time.timeScale = 0;
		uiText.text ="Game Over!";
		gameOver = true;
		
		//SceneManager.LoadScene(0);  //load a new scene
	}
		
	
	}

