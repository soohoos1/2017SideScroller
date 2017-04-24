using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bomb : MonoBehaviour {

	public int diameter = 5; 

	void OnCollisionEnter2D(Collision2D coll) 
	{
		var player = coll.gameObject.GetComponent<Player> ();
		if (player != null)  //! means not 
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

}
