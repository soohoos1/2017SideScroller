using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

	public GameObject youWinSign; 

	public void OnCollisionEnter2D(Collision2D coll) 
	{

		var player = coll.gameObject.GetComponent<Player> ();
		if (player != null)
		{

			DoYouWin (); 

		}

	}

	void DoYouWin ()
	{
		youWinSign.SetActive(true); 

	}
}
