using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	//https://docs.unity3d.com/ScriptReference/ use this for scripting behavior
	//unity engine, classes, monobehavior

	void OnCollisionEnter2D(Collision2D coll) 
	{
		var player = coll.gameObject.GetComponent<Player> ();
		if (player != null)  //! means not 
		{
			player.GetOut ();
		}

			
	}


}
