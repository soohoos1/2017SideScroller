﻿using UnityEngine;
using UnityEngine.UI;

public class GM : MonoBehaviour {

	private int _lives = 3;
	public int points;

	public Text pointsValue;
	public Text livesValue; 


	public void SetLives(int newvalue){
		_lives = newvalue; 
		Debug.Log ("lives now equal:" + _lives); 
		livesValue.text = _lives.ToString ();

	}

	public int GetLives()
	{
		return _lives;
	}
}