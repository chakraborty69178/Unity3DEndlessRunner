using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverCanvasController : MonoBehaviour {

	public Animator Rubyanim;
	public Animator GOSanim;
	public Text countdown;
	public GameObject rubyBarrier;
	public Collider[] CharecterCollider;
	public Text RubyText;
	[SerializeField]
	private Obstruckles obs;


	public GameObject objects;

	void Start()
	{
		objects = GetComponent<GameObject> ();
	}

	public void Continue()
	{
		StartCoroutine (RubyToOtherscreen ());

	}
	IEnumerator RubyToOtherscreen()
	{
		Rubyanim.SetTrigger ("off");
		yield return new WaitForSeconds (.5f);
		Rubyanim.gameObject.SetActive (false);
		GOSanim.gameObject.SetActive (true);
	}

	public void UseRuby()
	{
		if (Gamedata.instance.Ruby > 0 ) {
			GameManager.instance.canvasmode = true;

			StartCoroutine (UseRubyButton ());

		}
	}
	IEnumerator UseRubyButton()
	{	
		
		Rubyanim.SetTrigger ("off");
		yield return new WaitForSeconds (.8f);
		countdown.gameObject.SetActive (true);
		Rubyanim.gameObject.SetActive (false);
		countdown.text = "3";
		yield return new WaitForSeconds (1);
		countdown.text = "2";
		yield return new WaitForSeconds (1);
		countdown.text = "1";
		yield return new WaitForSeconds (1);
		countdown.gameObject.SetActive (false);
		yield return new WaitForSeconds (0.3f);
		GameManager.instance.isDead = false;
		GameManager.instance.audiosource.Play ();
		GameManager.instance.canPlay = true;

		GameManager.instance.Respawn ();
		Gamedata.instance.Ruby--;
		GameManager.instance.canvasmode = false;
		Rubyanim.gameObject.SetActive (false);
		rubyBarrier.SetActive (true);
		GameManager.instance.canBypass = true;
	
			yield return new WaitForSeconds (5);
		
		rubyBarrier.SetActive (false);
		GameManager.instance.canBypass = false;

		
	}
	void FixedUpdate()
	{
		RubyText.text = "x " + Gamedata.instance.Ruby;

	}


}
