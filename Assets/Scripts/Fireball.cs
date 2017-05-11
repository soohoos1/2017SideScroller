using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : Weapon {

	public bool isActive = false; 
	public float diameter = 2;

	void OnCollisionEnter2D(Collision2D collision) 
	{
		var player = collision.gameObject.GetComponent<Player> ();

		if (isActive && player == null) 
		{
			return;
		}
		isActive = true;
		base.GetPickedUp (player); 
	}
		


	public override void GetPickedUp(Player player)
	{
		if (isActive) {
			return;
		}
		isActive = true;
		base.GetPickedUp (player); 
	}
}
