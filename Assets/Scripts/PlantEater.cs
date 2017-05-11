using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantEater : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D coll) 
	{
		if (!enabled) 
		{
			return;
		}

		var player = coll.gameObject.GetComponent<Player> ();
		if (player != null) 
		{ 
			Time.timeScale = .2f;
		}
		else 
		{
			Time.timeScale = 1;
		}

	}
}
