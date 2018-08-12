using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour {

	public float damage = 1f;

	void OnTriggerEnter(Collider collider) {
		if(collider.gameObject.tag.Equals("Enemy")) {
			collider.gameObject.GetComponent<HealthController>().Damage(damage);
			Destroy(gameObject);
		}
	}
}
