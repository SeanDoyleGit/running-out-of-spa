using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProceduralBackground : MonoBehaviour {

	void OnTriggerExit(Collider other) {
		if(other.gameObject.tag.Equals("Space")) {
			float posX = other.transform.position.x;
			float posZ = other.transform.position.z;			
			
			if(Mathf.Abs(transform.position.x - other.transform.position.x) >= 450) {
				posX = other.transform.position.x + Mathf.Sign(transform.position.x - other.transform.position.x) * 900;
				Debug.Log(posX);
			}
			if(Mathf.Abs(transform.position.z - other.transform.position.z) >= 450) {
				posZ = other.transform.position.z + Mathf.Sign(transform.position.z - other.transform.position.z) * 900;
				Debug.Log(posZ);
			}
			other.transform.position = new Vector3(posX, other.transform.position.y, posZ);
		}
	}
}
