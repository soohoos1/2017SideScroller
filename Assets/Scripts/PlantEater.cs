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
			player.speed *= .5f;
			StartCoroutine (Slow (player));
		}
	
	}

	IEnumerator Slow (Player player)
	{
		yield return new WaitForSeconds (10);
		player.speed /= .5f;
	}
}