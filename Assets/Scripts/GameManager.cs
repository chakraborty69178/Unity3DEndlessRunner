using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	public static GameManager instance;

	[HideInInspector]public int count = 0;
	[HideInInspector]public Vector3 currenntSpawnlocation;
	[HideInInspector]public Quaternion currentRotation;
	public Vector3 playerSpawnLocation;
	public Vector3 charecterspawnloc;
	[HideInInspector]public bool isDead=false;
	[HideInInspector]public int respawncounter=1;
	public GameObject Charecter;
	public RagdollScript ragdollscript;
	public int score;
	public Text ScoreText;
	//public GameObject gameOver;
	public GameObject RubyScreen;
	public PlayerSpawner playerspawner;
	public Transform playerSpawnPoint;
	public GameObject player;
	public bool canvasmode=false;
	[HideInInspector]public bool deadpointer=false;
	public int behind;
	//[HideInInspector]
	public bool canBypass = false;
	public bool isGrounded = true;
	[HideInInspector]
	public bool canPlay=true;
	[HideInInspector]
	public bool canTurn=false;
	 public Transform turnlocation;

	[HideInInspector]public int BridgeCounterForDiffrentType=0;

	public AudioSource audiosource;
	void Awake () {
		if (instance == null) {
			instance= this;

		}

		else if (instance != null)
			Destroy (gameObject);


	}
	void Start () {
		ragdollscript.ReferAnimation ();
		playerSpawnLocation = Charecter.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (canvasmode==false) {
			//Debug.Log ("U[date called");
			if(isDead)
			StartCoroutine (GameOverScreenDelay ());
			
			
			}


	}
	void FixedUpdate()
	{
		ScoreText.text = "" + score;
		/*if (!isGrounded) {
			StartCoroutine (Grounded ());
		}*/
	}
	IEnumerator GameOverScreenDelay (){
		ragdollscript.ReferRagDoll ();
		audiosource.Stop ();
		yield return new WaitForSeconds (0.8f);
		RubyScreen.gameObject.SetActive (true);

	}
	public void Respawn()
	{
		ragdollscript.ReferAnimation ();
		Charecter.transform.position = Charecter.transform.position-new Vector3(0,0,behind);
		player.transform.position = playerSpawnPoint.position;
		//RubyScreen.SetActive(true);
		respawncounter++;

	}
	IEnumerator Grounded()
	{	
		isGrounded = false;
		yield return new WaitForSeconds (1f);
		isGrounded = true;
	}

}
