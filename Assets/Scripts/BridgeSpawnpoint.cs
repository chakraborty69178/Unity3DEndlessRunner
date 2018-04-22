using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeSpawnpoint : MonoBehaviour {

	public GameObject spawnpoint;
	Vector3 SpawnLocation;
	Quaternion quaternion;
	public GameObject bridge;
	public GameObject LeftBridge;
	bool spawned =false;
	public bool ninetyDegree=false;
	public int SpawnLimit;
	public Transform TurnLoction;


	public bool canSpawn = false;
	//[SerializeField]
	//int bridgeChange;
	void Start () {
		quaternion = spawnpoint.transform.rotation;
		SpawnLocation = spawnpoint.gameObject.transform.position;
		GameManager.instance.currenntSpawnlocation = SpawnLocation;
		GameManager.instance.currentRotation = quaternion;
		//bridgeChange = Random.Range (6, 9);

	}
	
	// Update is called once per frame
	void Update () {
		if (!spawned&&GameManager.instance.count<=SpawnLimit ) {
			spawn ();
			quaternion = spawnpoint.transform.rotation;
			SpawnLocation = spawnpoint.gameObject.transform.position;

		}
	}

	void spawn()
	{	
		if (GameManager.instance.BridgeCounterForDiffrentType <(int)Random.Range(6,9)) {
			GameObject.Instantiate (bridge, SpawnLocation, quaternion);
			spawned = true;
		} 
		else  {
			GameObject.Instantiate (LeftBridge, SpawnLocation, quaternion);
			spawned = true;
			GameManager.instance.BridgeCounterForDiffrentType = 0;
		}
		GameManager.instance.count++;
		GameManager.instance.BridgeCounterForDiffrentType++;
	}

	public void Pooling()
	{
		this.gameObject.transform.position=GameManager.instance.currenntSpawnlocation;
		this.gameObject.transform.rotation = GameManager.instance.currentRotation;
		GameManager.instance.currenntSpawnlocation=spawnpoint.gameObject.transform.position;
		GameManager.instance.currentRotation = spawnpoint.gameObject.transform.rotation;
	}
	void OnTriggerExit(Collider col)
	{
		if (col.gameObject.tag == "Player") {
			if (!canSpawn) {
				if(!ninetyDegree)
					Pooling ();
			}

			GameManager.instance.canTurn = false;
		}

	}
	void OnTriggerEnter(Collider col)
	{
		if (ninetyDegree) {

			GameManager.instance.turnlocation = TurnLoction;
		}
	}
}
