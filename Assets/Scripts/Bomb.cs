using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bomb : Weapon {

	public float diameter = 5; 
	public bool isActive = false; 


	void Update ()
	{

	}

	void OnCollisionEnter2D(Collision2D collision) 
	{
		var player = collision.gameObject.GetComponent<Player> ();

		if (isActive && player == null) 
		{
			Explode ();
		}
	}

	public override void Attack ()
	{
		this.transform.parent = null;
		rigidbody2D.isKinematic = false;
		rigidbody2D.velocity = new Vector2 (5, 0);
		collider2D.enabled = true;

	}

	public override void GetPickedUp(Player player)
	{
		if (isActive) 
		{
			return;
		}
		isActive = true;
		base.GetPickedUp (player); 
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
	}

}
