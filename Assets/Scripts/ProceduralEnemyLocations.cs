using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProceduralEnemyLocations : MonoBehaviour {

	EnemySpawner enemySpawner;

	// Use this for initialization
	void Start () {
		enemySpawner = GetComponent<EnemySpawner>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerExit(Collider other) {
		if(other.gameObject.tag.Equals("Enemy") && other.isTrigger) { 
			Destroy(other.gameObject); 
			enemySpawner.SpawnEnemy();
		} else if(other.gameObject.tag.Equals("Shot")) { 
			Destroy(other.gameObject); 
		}
	}
}
