using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MainCanvasController : MonoBehaviour {
	public Text HighScore;
	public Text RubyText;
	
	void Start () {
		if (Gamedata.instance != null) {
			if (HighScore != null && RubyText != null) {
				HighScore.text = "HS = " + Gamedata.instance.highscore;
				RubyText.text = "Ruby = " + Gamedata.instance.Ruby;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Gamedata.instance != null) {
			if (HighScore != null && RubyText != null) {
				HighScore.text = "HS = " + Gamedata.instance.highscore;
				RubyText.text = "Ruby = " + Gamedata.instance.Ruby;
			}
		}
	}


}
