using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchManager : MonoBehaviour {

	public static TouchManager instance;

	public float maxTime;
	public float minSwipeDist;

	float startTime;
	float endTime;

	Vector3 startPos;
	Vector3 endPos;

	float swipeDist;
	float swipeTime;

	public string swipeType;


	void Awake () {
		if (instance == null) {
			instance= this;

		}

		else if (instance != null)
			Destroy (gameObject);


	}
	

	void Update () {
		if (Input.touchCount > 0)
		{
			Touch touch = Input.GetTouch (0);
			if (touch.phase == TouchPhase.Began) {
				startTime = Time.time;
				startPos = touch.position;
			} 
			else if (touch.phase == TouchPhase.Ended) 
			{
				endTime = Time.time;
				endPos = touch.position;
				swipeDist = (endPos - startPos).magnitude;
				swipeTime = endTime - startTime;
				if (swipeTime < maxTime && swipeDist > minSwipeDist) 
				{
					Swipe ();
				}
			}
		}
	}

	void Swipe()
	{
		Vector2 distance = endPos - startPos;
		if (Mathf.Abs (distance.x) > Mathf.Abs (distance.y)) 
		{
			if (distance.x > 0) {
				swipeType = "Right";
			} else if (distance.x < 0) {
				swipeType="Left";
			}
		}

		else if (Mathf.Abs (distance.x) < Mathf.Abs (distance.y)) 
		{
			if (distance.y > 0) {
				swipeType = "Up";
			} else if (distance.y < 0) {
				swipeType="Down";
			}
		}
	}
}
