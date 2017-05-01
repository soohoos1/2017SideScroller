using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StunGrenade : Throwable {

	public float diameter = 5; 



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


	public void Explode ()
	{
		var enemies = FindObjectsOfType <Enemy>();
		foreach (var e in enemies) 
		{
			if(Vector3.Distance(this.transform.position, e.transform.position) < diameter)
			{
				StartCoroutine(Stun (e)); 
			}
		}

		collider2D.enabled = false; 
		GetComponent <SpriteRenderer> ().enabled = false; 
	}

	IEnumerator Stun (Enemy e)
	{
		var Renderer = e.GetComponent<SpriteRenderer> ();

		e.enabled = false; 
		Renderer.color = new Color (1, 1, 1, .4F);
		yield return new WaitForSeconds (5);

		e.enabled = true;
	}


}
