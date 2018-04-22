using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dieing : MonoBehaviour {
	public bool Turn=false;

	void OnCollisionEnter(Collision col)
	{	if (!Turn) {
			if (col.gameObject.tag == "Player") {
				Debug.Log ("isDead");
				GameManager.instance.isDead = true;
			}
		} 
		else {
			if (GameManager.instance.canTurn) {
				if (col.gameObject.tag == "Player") {
					Debug.Log ("isDead");
					GameManager.instance.isDead = true;

				}
			}
	}
}
}
