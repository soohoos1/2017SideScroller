﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour 
{

	protected new Rigidbody2D rigidbody2D; 
	protected new Collider2D collider2D; 

	void Start ()
	{
		rigidbody2D = GetComponent <Rigidbody2D>();
		collider2D = GetComponent <Collider2D>(); 
	}


	// Update is called once per frame
	void Update () 
	{

	}

	public virtual void Attack ()
	{
		
	}

	public virtual void GetPickedUp (Player player)
	{
		Debug.Log ("Got Picked Up");
		collider2D.enabled = false;
		rigidbody2D.isKinematic = true;
		rigidbody2D.velocity = new Vector2 ();
		transform.parent = player.transform; 
		transform.localScale = new Vector3 (.02f, .02f);
		transform.localPosition = new Vector3 (.02f, .02f);
		player.AddWeapon (this);


	}
}
