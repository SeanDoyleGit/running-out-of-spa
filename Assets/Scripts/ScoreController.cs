using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

	public Text scoreValue;
	public Text healthValue;
	float score = 0;

	HealthController playerHealth;

	void Start() {
		playerHealth = GameObject.FindWithTag("Player").GetComponent<HealthController>();
	}

	void Update() {
		if(playerHealth) {
			healthValue.text = playerHealth.GetCurrentHealth().ToString();
		}
	}

	public void IncrementScore() {
		score++;
		scoreValue.text = score.ToString();
	}

	public float GetScore() {
		return score;
	}
}
