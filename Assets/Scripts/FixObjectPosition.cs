using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixObjectPosition : MonoBehaviour {

	Rigidbody rigidbody;
	// Use this for initialization
	void Start () {
		rigidbody = GetComponent <Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.position = new Vector3(transform.position.x, 0, transform.position.z);
		rigidbody.velocity = new Vector3(rigidbody.velocity.x, 0, rigidbody.velocity.z);
	}
}
