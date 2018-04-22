using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharecterController : MonoBehaviour {

//	Rigidbody rigid;
	public float speed;
	public float axis;
	//[SerializeField]
	//private float MaxValueOfAxis;
	public Rigidbody charecterRigid;
	int score=100;
	float speedTemp=1;
	float axisTemp=5;
	[SerializeField]private float jumpForce;
	[SerializeField]
	private Animator anim;

	void Start () {
		anim = GetComponentInChildren<Animator> ();

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		if (GameManager.instance.isDead==false&& GameManager.instance.canvasmode==false) {
		//if (GameManager.instance.score==score) {
				//speed += speedTemp;
				//axis += axisTemp;
				//score = score * 2;
				//speedTemp = speedTemp * 2;
				//axisTemp = axisTemp * 2;

			//}
			axis+=0.0005f;
			speed += 0.0008f;

			transform.Translate (0, 0, Time.deltaTime * speed);


			charecterRigid.gameObject.transform.Translate (new Vector3 (Input.acceleration.x * speed * Time.deltaTime, 0, 0));

			if (Input.GetKeyDown (KeyCode.Space) ) {
				if(GameManager.instance.isGrounded == true)
				{
				anim.SetTrigger ("Jump");
					charecterRigid.AddForce (0, jumpForce*Time.deltaTime, 0);
					//charecterRigid.gameObject.transform.Translate(Vector3.up * 80 * Time.deltaTime, Space.World);
				GameManager.instance.isGrounded = false;
				}
			}

			if (TouchManager.instance.swipeType=="Up" ) {
				if(GameManager.instance.isGrounded == true)
				{
					anim.SetTrigger ("Jump");
					charecterRigid.AddForce (0, jumpForce*1.5f*Time.deltaTime, 0);
					GameManager.instance.isGrounded = false;
					TouchManager.instance.swipeType = "";
				}
			}
			if (TouchManager.instance.swipeType=="Left"||Input.GetKeyDown(KeyCode.LeftArrow) ) {
				if (GameManager.instance.canTurn&&!GameManager.instance.isDead) {
					this.gameObject.transform.Rotate (0,-90,0);
					this.gameObject.transform.position = GameManager.instance.turnlocation.position;
					TouchManager.instance.swipeType = "";
					GameManager.instance.canTurn = false;
				}

			}
			if (TouchManager.instance.swipeType=="Right"||Input.GetKeyDown(KeyCode.RightArrow) ) {

				if (GameManager.instance.canTurn&&!GameManager.instance.isDead) {
					this.gameObject.transform.Rotate (0,90,0);
					this.gameObject.transform.position = GameManager.instance.turnlocation.position;
					TouchManager.instance.swipeType = "";
					GameManager.instance.canTurn = false;


				}

			}



			if (GameManager.instance.isGrounded) {
				anim.SetBool ("IsGrounded", true);
			}
			anim.SetFloat("Left",0.5f);

			//charecterRigid.AddForce (Time.deltaTime * (axis*Gamedata.instance.GsenserValue) * Input.acceleration.x, 0, 0);
			anim.SetFloat("Left",Input.acceleration.x+0.5f);

		
		
		
		}



	}
}
