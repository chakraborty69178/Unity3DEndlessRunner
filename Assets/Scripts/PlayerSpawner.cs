using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour {
	public GameObject player;
	public Transform point;


	

	void Update () {
		

	}
	public void instantiate ()
	{
		if (GameManager.instance.isDead == false) {
			player.transform.position = point.position;
		}
	}
}
