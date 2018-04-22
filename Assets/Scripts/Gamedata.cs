using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gamedata : MonoBehaviour {

	public static Gamedata instance;
	public int highscore;
	public int Ruby=0;
	public float axis;
	public float GsenserValue=1;

	public Slider slider;

	void Awake () {
		if (instance == null) {
			instance= this;

		}

		else if (instance != null)
			Destroy (gameObject);

		DontDestroyOnLoad(this);
	}
	void Start () {
		slider = GameObject.Find ("Slider").GetComponent<Slider> ();
		highscore = PlayerPrefs.GetInt ("HighScore");
		Ruby = PlayerPrefs.GetInt ("Ruby");
		GsenserValue = PlayerPrefs.GetFloat ("gsenser");
		slider.value = GsenserValue;
		Screen.sleepTimeout = SleepTimeout.NeverSleep;
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{	if(slider!=null)
		slider.value = GsenserValue;
		if (GameManager.instance != null) {
			if (GameManager.instance.isDead && GameManager.instance.score > highscore) {
				highscore = GameManager.instance.score;

			}
			if (GameManager.instance.isDead) {
				PlayerPrefs.SetInt ("Ruby", Ruby);
				PlayerPrefs.SetInt ("HighScore", highscore);
			}
		}

	}

	public void ChangeVal()
	{	
		if (slider != null) {

			GsenserValue = slider.value;
			slider.value = GsenserValue;
			PlayerPrefs.SetFloat ("gsenser", GsenserValue);
		} else
			Debug.Log ("Nothing in the slider");
	}
}
