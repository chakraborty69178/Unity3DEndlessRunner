using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxisControl : MonoBehaviour {
	//Rigidbody rigid;
	public Animator anim;
	public float axis=5;
	// Use this for initialization
	void Start () {
		//rigid=GetComponent<Rigidbody> ();
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		anim.speed += 0.000005f;
	}

}
