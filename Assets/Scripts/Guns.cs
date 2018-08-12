using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guns : MonoBehaviour {

	public GameObject shot;
	public float shotSpeed = 100f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire")) {
			GameObject currentShot = Instantiate(shot, transform.position + transform.forward.normalized * 2f, Quaternion.Euler(0,transform.eulerAngles.y,0));
			currentShot.GetComponent<Rigidbody>().velocity = transform.forward.normalized * shotSpeed;
		}
	}
}
