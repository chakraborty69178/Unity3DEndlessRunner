using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour {

	public bool Ruby;
	public bool coins;

	public GameObject RubyMesh;
	public Gamedata Coins;

	public void OnTriggerEnter(Collider col)
	{
		Debug.Log ("Collided");
		if (col.gameObject.tag == "Player") {
			if (Ruby) {
				Gamedata.instance.Ruby++;
				if (RubyMesh != null)
					RubyMesh.SetActive (false);

			}
		}

	}
}
