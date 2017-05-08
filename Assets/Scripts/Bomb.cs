using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bomb : Throwable {

	public float diameter = 5; 


	void OnCollisionEnter2D(Collision2D collision) 
	{
		var player = collision.gameObject.GetComponent<Player> ();

		if (isActive && player == null) 
		{
			Explode ();
		}
	}
		

	public void Explode ()
	{
		var enemies = FindObjectsOfType <Enemy>();
		foreach (var e in enemies) 
		{
			if(Vector3.Distance(this.transform.position, e.transform.position) < diameter)
			{
				e.gameObject.SetActive(false);
			}
		}

		gameObject.SetActive (false);
	}

}
