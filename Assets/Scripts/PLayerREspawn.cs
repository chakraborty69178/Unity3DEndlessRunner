using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerREspawn : MonoBehaviour {

	public Transform CharecterSpawnpoint;
	public Vector3 charecterspawnlocation;


	
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player") {
			GameManager.instance.playerSpawnLocation= CharecterSpawnpoint.position;
		}

	}


}
