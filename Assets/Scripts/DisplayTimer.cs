using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayTimer : MonoBehaviour {

	public Text timer;

	GameObject player;
	float timeSurvived = 0;

	void Start() {
		player = GameObject.FindWithTag("Player");
	}

	// Update is called once per frame
	void Update () {
		if(player) {
			timeSurvived = Time.timeSinceLevelLoad;
			string minutes = Mathf.Floor(timeSurvived / 60).ToString("00");
 			string seconds = Mathf.RoundToInt(timeSurvived%60).ToString("00");

			timer.text = minutes + ":" + seconds;
		}
	}

	public float GetTimeSurvived() {
		return timeSurvived;
	}
}
