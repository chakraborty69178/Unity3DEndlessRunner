using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nintyDegscript : MonoBehaviour {

	public BridgeSpawnpoint bridge;
	void Start () {
		bridge = GetComponentInParent<BridgeSpawnpoint> ();
	}
	
	void OnTriggerExit()
	{	
		if (bridge.canSpawn) {

			bridge.Pooling ();
		}
	}
}
