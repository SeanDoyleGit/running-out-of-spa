using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boosters : MonoBehaviour {

	public float boostAmount = 1;
	public float idolAmount = 1;
	public ParticleSystem leftBooster;
	public ParticleSystem rightBooster;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		var leftBoosterParticles = leftBooster.main;
		var rightBoosterParticles = rightBooster.main;

		if(Input.GetButton("Boost")) {
			leftBoosterParticles.startLifetime = boostAmount;
			rightBoosterParticles.startLifetime = boostAmount;
		} else {
			leftBoosterParticles.startLifetime = idolAmount;
			rightBoosterParticles.startLifetime = idolAmount;
		}
	}
}
