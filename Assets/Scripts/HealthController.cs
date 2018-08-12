using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour {

	public float initialHealth = 1f;
	public GameObject createOnDestroy;

	float currentHealth;

	// Use this for initialization
	void Start () {
		currentHealth = initialHealth;
	}
	
	public void Damage(float damage) {
		currentHealth -= damage;
		if(currentHealth <= 0) {
			Destroy(gameObject);
		}
	}

	void OnDestroy() {
		if(createOnDestroy != null) {
			Instantiate(createOnDestroy, transform.position, Quaternion.Euler(0,0,0));
		}
	}
}
