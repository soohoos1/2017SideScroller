using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballPower : MonoBehaviour {

	public GameObject projectile;
	public Vector2 velocity;
	bool canShoot = true;
	public Vector2 offset = new Vector2 (.4f, .1f);
	public float cooldown = 1f;

	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Z) && canShoot) 
		{
			GameObject go = (GameObject)Instantiate (projectile, (Vector2)transform.position + offset * transform.localScale.x, Quaternion.identity);
			go.GetComponent<Rigidbody2D> ().velocity = new Vector2 (velocity.x * transform.localScale.x, velocity.y);	
		}
	}

	IEnumerator CanShoot()
	{
		canShoot = false;
		yield return new WaitForSeconds (cooldown);
		canShoot = true; 
	}
}
