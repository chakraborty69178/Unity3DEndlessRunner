using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Isgrounded : MonoBehaviour {

	void OnCollisionStay(Collision col)
	{
		if (col.gameObject.tag == "Player") {
			GameManager.instance.isGrounded = true;
			//Debug.Log (GameManager.instance.isGrounded);
		}
	}
	void OnCollisionExit(Collision col)
	{
		if (col.gameObject.tag == "Player") {
			GameManager.instance.isGrounded = false;
			//Debug.Log (GameManager.instance.isGrounded);
		}
	}
	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Player") {
			GameManager.instance.isGrounded = true;
			//Debug.Log (GameManager.instance.isGrounded);
		}
	}
}
