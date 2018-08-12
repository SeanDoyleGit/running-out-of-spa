using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public float maxSpeed = 10f; 
	public float minSpeed = 3f;
	public float acceleration = 12f;
	public float agroDistance = 10f;
	public float MaxRotSpeed = 40f;
	public float MinRotSpeed = 1f;
	GameObject player;
	Rigidbody rigidbody;
 
	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag("Player");
		rigidbody = GetComponent <Rigidbody> ();
		rigidbody.velocity = (player.transform.position - transform.position).normalized * minSpeed;
	}
	
	// Update is called once per frame
	void Update () {
		float rotSpeed = MaxRotSpeed/Vector3.Distance(transform.position, player.transform.position);
		rotSpeed = Mathf.Clamp(rotSpeed, MinRotSpeed, MaxRotSpeed);
		transform.Rotate(0, rotSpeed, 0);
	}

	void FixedUpdate() {
		Vector3 dir = (player.transform.position - transform.position).normalized;
		if(Vector3.Distance(transform.position, player.transform.position) < agroDistance) {
			rigidbody.AddForce(dir * acceleration);

			if(rigidbody.velocity.magnitude > maxSpeed) {
				rigidbody.velocity = rigidbody.velocity.normalized * maxSpeed;
			}
		} else if(rigidbody.velocity.magnitude < minSpeed) {
			rigidbody.velocity = dir * minSpeed;
		}	
	}
}
