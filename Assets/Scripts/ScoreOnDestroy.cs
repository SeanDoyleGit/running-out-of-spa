using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreOnDestroy : MonoBehaviour {

    ScoreController scoreController;
    HealthController healthController;

    void Start() {
        scoreController = GameObject.FindWithTag("GameController").GetComponent<ScoreController>();
        healthController = GetComponent<HealthController>();
    }

    void OnDestroy() {
        if(healthController.GetCurrentHealth() <= 0) {
            scoreController.IncrementScore();
        }
    }
}
