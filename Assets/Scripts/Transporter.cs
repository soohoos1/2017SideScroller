using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transporter : MonoBehaviour {

	public Transform warpTarget;

	public Transform WarpTarget 
	{
		get {
			return warpTarget;
		}

		set {
			warpTarget = value;
		}

	}

	void OnTriggerEnter2D (Collider2D other)
	{
		Debug.Log ("Object Collided");
		other.gameObject.transform.position = WarpTarget.transform.position;
	}

}
