using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge_Turn_Script : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter()
	{
		if (!GameManager.instance.canTurn) {
			GameManager.instance.canTurn = true;
			//Debug.Log ("canTurn =" + GameManager.instance.canTurn);
		}
	}
	void OnTriggeExit()
	{
		if (GameManager.instance.canTurn) {
			GameManager.instance.canTurn = false;
			Debug.Log ("canTurn =" + GameManager.instance.canTurn);
		}
	}
}
