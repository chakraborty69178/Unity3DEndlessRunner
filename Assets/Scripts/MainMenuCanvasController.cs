using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MainMenuCanvasController : MonoBehaviour {

	public Text HighScore;
	[SerializeField]
	Slider slider;
	void Start () {
		HighScore.text = "H.S = " + Gamedata.instance.highscore;
		slider = GameObject.Find ("Slider").GetComponent<Slider> ();
		Gamedata.instance.slider = slider;
	}
	
	// Update is called once per frame
	void Update () {
		//Gamedata.instance.slider = slider;
	}
	public void onQuit()
	{
		Application.Quit ();
	}
}
