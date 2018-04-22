using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstruckles : MonoBehaviour {

	public Collider[] Ob;
	public MeshCollider[] obstrucklesToDisableDuringRespawn;
	public int range;
	void Start () {
		for (int x = 0; x < range; x++) {
			Ob [x].gameObject.SetActive (false);
		}
		Ob [Random.Range (0, range)].gameObject.SetActive (true);
	}
	
	void OnTriggerEnter(Collider col)
	{
		for (int x = 0; x < range; x++) {
			Ob [x].gameObject.SetActive (false);
		}
		Ob [Random.Range (0, range)].gameObject.SetActive (true);
	}
	void Update()
	{
		if (GameManager.instance.canBypass) {
			foreach (MeshCollider col in obstrucklesToDisableDuringRespawn) {
				//col.convex = true;
				col.isTrigger = true;
			}
				
		} else {
			foreach (MeshCollider col in obstrucklesToDisableDuringRespawn) {
				//col.convex = true;
				col.isTrigger = false;
			}
		}
	}

}
