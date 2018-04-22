using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharecterAudioController : MonoBehaviour {

	public AudioClip footstep;
	public AudioClip Hit;
	AudioSource audiosource;
	void Start()
	{
		audiosource = GetComponent<AudioSource> ();
	}

	void Play()
	{	
		if (GameManager.instance.isGrounded) {
			audiosource.clip = footstep;
			audiosource.Play ();
		}
	}

	void Update()
	{
		if (GameManager.instance.isDead) {
			if (GameManager.instance.canPlay) {
				audiosource.clip = Hit;
				audiosource.Play ();
				GameManager.instance.canPlay = false;
			}
		}
	}

}
