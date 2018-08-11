using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour {
 
	public float speed = 1.0f;
	public float yawSpeed = 0.02f;
	public float maxRoll = 60f;

	Rigidbody rigidbody;
	int spaceLayer;
	float camRayLength = 100f; 

	float totalYaw = 0;
	float totalRoll = 0;

	// Use this for initialization
	void Start () {
		spaceLayer = LayerMask.GetMask ("Space");
		rigidbody = GetComponent <Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {
		Ray camRay = Camera.main.ScreenPointToRay (Input.mousePosition);
        RaycastHit hit;

        if(Physics.Raycast (camRay, out hit, camRayLength, spaceLayer)) {

			Vector3 hitPoint = new Vector3(hit.point.x, 0f, hit.point.z);
			Vector3 oldForward = transform.forward;

			Vector3 targetDir = hit.point - transform.position;
			float angle = Vector2.SignedAngle(new Vector2(transform.forward.z, transform.forward.x), new Vector2(targetDir.z, targetDir.x));

			totalYaw += angle * yawSpeed;
			totalRoll = Mathf.Clamp(-angle, -maxRoll, maxRoll);

			if( -1 < totalYaw + angle && totalYaw + angle < 1) { totalYaw = 0; }
			if( -1 < totalRoll && totalRoll < 1) { totalRoll = 0; }

			transform.rotation = Quaternion.Euler(0f, totalYaw, totalRoll);
        }
	}

	void FixedUpdate() {
		rigidbody.velocity = transform.forward.normalized * speed;
	}
}
