﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public int health = 100;
	public float speed = 5; 
	public float jumpSpeed = 5;
	public float deadZone= -5;

	new Rigidbody2D rigidbody; 


	// Use this for initialization
	void Start () {
		rigidbody = GetComponent<Rigidbody2D>(); 
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float x = Input.GetAxisRaw ("Horizontal");
		Vector2 v = rigidbody.velocity;
		v.x = x * speed;

		//rigidbody.velocity = new Vector2 (x * speed, rigidbody.velocity.y);

		if (Input.GetButtonDown ("Jump")) 
		{
			v.y = jumpSpeed;
		
		}

		rigidbody.velocity = v;
		//rigidbody.AddForce(new Vector2 (x * speed, 0));


		if (transform.position.y < deadZone) 
		{
			Debug.Log ("You're Out"); 
		}
	}
}