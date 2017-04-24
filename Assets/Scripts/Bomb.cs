using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bomb : MonoBehaviour {

	public float diameter = 5; 
	public bool isActive = false; 

	private new Rigidbody2D rigidbody2D; 
	private new Collider2D collider2D; 

	void Start ()
	{
		rigidbody2D = GetComponent <Rigidbody2D>();
		collider2D = GetComponent <Collider2D>(); 
	}

	void Update ()
	{
		if(Input.GetButtonDown("Fire1") && isActive )
			{
				Throw();
			}
	}

	void OnCollisionEnter2D(Collision2D collision) 
	{
		var player = collision.gameObject.GetComponent<Player> ();
		if (player != null && !isActive) //! means not 
		{
			GetPickUp (player);
		}
		if (isActive && player == null) 
		{
			Explode ();
		}
	}

	public void Throw ()
	{
		this.transform.parent = null;
		rigidbody2D.isKinematic = false;
		rigidbody2D.velocity = new Vector2 (5, 0);
		collider2D.enabled = true;

	}

	public void GetPickUp(Player player)
	{
		Debug.Log ("Got Picked Up");
		isActive = true;
		this.transform.parent = player.transform; 
		transform.localScale = new Vector3 (.02f, .02f);
		transform.localPosition = new Vector3 (.02f, .02f);
		rigidbody2D.isKinematic = true;
		rigidbody2D.velocity = new Vector2 ();
		collider2D.enabled = false;

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
