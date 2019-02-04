using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreBoard : MonoBehaviour
{

	public GameObject user1;
	public GameObject user2;
	private GameObject finsh;

	public Text finishString;
	public Text score1;

	public Text score2;
	
	private PlayerController comp1,comp2;
	private CountdownScript scp;

	// Use this for initialization
	void Start()
	{
		comp1 = user1.GetComponent<PlayerController>();
		comp2 = user2.GetComponent<PlayerController>();
		finsh= GameObject.Find("TimerController"); //link to time controller
		if (finsh != null)
		{
			scp = finsh.GetComponent<CountdownScript>();
		}

	}

	// Update is called once per frame
	void Update()
	{
		bool done= scp.gameOver;
		if (comp1 != null&&comp2!=null)
		{
			score1.text = ""+comp1.score;
			score2.text = ""+comp2.score;
		}

		if (!done)
		{
			finishString.gameObject.SetActive(false);
		}
		else
		{
			finishString.gameObject.SetActive(true);
			String mes = "";
			if (comp1.score > comp2.score)
			{
				mes = "Player 1 wins";
			}
			else if(comp2.score>comp1.score)
			{
				mes = "Player 2 wins";
			}
			else
			{
				mes = "Draw";
			}

			finishString.text = mes;
		}
	}
}	
