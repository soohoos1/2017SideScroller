﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingBooster : MonoBehaviour {

	float timeStarted = 0;
	Player player; 


	public float lastForSeconds = 10;


	void OnCollisionEnter2D(Collision2D coll) 
	{
		player = coll.gameObject.GetComponent<Player> ();
		if (player != null)  
			//! means not and in this step, we're giving a reference to the player
		{
			player.canFly = true;
			gameObject.GetComponent<Collider2D> ().enabled = false;
			gameObject.GetComponent<SpriteRenderer> ().enabled = false; 

			timeStarted = Time.time;
		}


	}

	void Update ()
	{
		if (timeStarted != 0 && timeStarted + lastForSeconds < Time.time) 
		{
			timeStarted = 0;
			player.canFly = false; 
		}
	}
}
