using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour {

	public float damage = 1f;
	public string targetTag = "Enemy";

	void OnTriggerEnter(Collider collider) {
		if(collider.gameObject.tag.Equals(targetTag)) {
			collider.gameObject.GetComponent<HealthController>().Damage(damage);
			Destroy(gameObject);
		}
	}
}
