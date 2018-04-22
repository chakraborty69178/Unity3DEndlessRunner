using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollScript : MonoBehaviour {

	Collider[] ragdollCollider;
	Rigidbody[] ragdollRigid;
	Animator anim;
	public float force;
	void Start () {
		
		ragdollCollider = GetComponentsInChildren<Collider> ();
		ragdollRigid = GetComponentsInChildren<Rigidbody> ();
		anim = GetComponent<Animator> ();
			

			
			}


	public void ReferAnimation()
	{
		foreach (Rigidbody rig in ragdollRigid) {

			if (rig.gameObject.layer == 9) {
				rig.isKinematic = true;
			}

		}
		anim.enabled = true;

		foreach (Collider col in ragdollCollider) {

				if (col.gameObject.layer == 9) {
					col.isTrigger = true;
				}
			}
	}
	

	public void ReferRagDoll()
	{
		foreach (Rigidbody rig in ragdollRigid) {
			
			if (rig.gameObject.layer == 9) {
				rig.isKinematic = false;
				rig.AddForce (0, 0, Time.deltaTime * force);
			}
		}
		anim.enabled = false;

		foreach (Collider col in ragdollCollider) {
			
			if (col.gameObject.layer == 9) {
				col.isTrigger = false;
				}
			}

	}


	

	}
