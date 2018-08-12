using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTimer : MonoBehaviour {

	public float lifetime = 1f;

	// Use this for initialization
	void Start () {
		StartCoroutine("DestroyAfter");
	}
	
    IEnumerator DestroyAfter()
    {
        yield return new WaitForSeconds(lifetime);
        Destroy(gameObject);
    }
}
