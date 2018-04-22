using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadLevel : MonoBehaviour {
	public string levNmae;
	public void Replay()
	{
		SceneManager.LoadScene (levNmae);
	}
	public void SliderChange()
	{
		Gamedata.instance.ChangeVal ();
	}

}
