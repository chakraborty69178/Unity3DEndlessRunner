using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoringSystem : MonoBehaviour {

	public Vector3 Startposition;
	int oldDistance=0;
	void Awake () {
		Startposition = this.transform.position;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(!GameManager.instance.isDead)
		GameManager.instance.score = oldDistance + (int)Vector3.Distance (Startposition, this.transform.position);
	}
}
