using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScreenController : MonoBehaviour {

	public Button replayButton;
	public Text score;
	public Text scoreValue;
	public Text timeSurvived;
	
	ScoreController scoreController;
	DisplayTimer displayTimer;

	void Start () {
		Destroy(GameObject.FindWithTag("ScoreHealthCanvas"));
		scoreController = GameObject.FindWithTag("GameController").GetComponent<ScoreController>();
		displayTimer = GameObject.FindWithTag("GameController").GetComponent<DisplayTimer>();
		replayButton.enabled = false;
		scoreValue.text = scoreController.GetScore().ToString();

		string minutes = Mathf.Floor(displayTimer.GetTimeSurvived() / 60).ToString();
		string seconds = Mathf.RoundToInt(displayTimer.GetTimeSurvived()%60).ToString();

		timeSurvived.text = "Congratulations you survived for " + minutes + " minutes and " + seconds + " seconds!";

		StartCoroutine("EnableReplayButton");
	}

	IEnumerator EnableReplayButton() {
		yield return new WaitForSeconds(3);
		replayButton.enabled = true;
	}
}
