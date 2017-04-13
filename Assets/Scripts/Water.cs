using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void On QueryTriggerEnter2D(Collider2D collision)
	{
		var player = collision.gameObject.GetComponent<Player>();
		if (player != null)
		{
			player.canFly = true;
		}
	}

	public void On QueryTriggerEnter2D(Collider2D collision)
	{
		var player = collision.gameObject.GetComponent<Player>();
		if (player != null)
		{
			player.canFly = false;
		}
	}
}
