using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour {

	public Rigidbody2D rb;
	public Vector2 velocity;

	void Start ()
	{
		Destroy (this.gameObject, 5.1f);
		rb = GetComponent<Rigidbody2D> ();
		velocity = rb.velocity;
	}

	void Update ()
	{
		if (rb.velocity.y < velocity.y) 
		{
			rb.velocity = velocity;
		}
	}

	void OnCollisionEnter2D (Collision2D col)
	{ 
		rb.velocity = new Vector2 (velocity.x, -velocity.y);
		if (col.collider.tag == "deadly") 
		{
			Destroy (col.gameObject);
			Explode ();
		}
	}

	void Explode ()
	{
		Destroy (this.gameObject);
	}
}
