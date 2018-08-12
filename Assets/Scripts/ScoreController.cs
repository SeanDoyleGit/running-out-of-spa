using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

	public Text scoreValue;
	float score = 0;

	public void IncrementScore() {
		score++;
		scoreValue.text = score.ToString();
	}
}
