using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

	public GameObject Enemy;
	public float secondsPerSpawn = 5f;
	public float spawnIncreaseRate = 0.9f;

	float currentSecondsPerSpawn;
	float timeSinceLastSpawn = 0;

	void Start () {
		currentSecondsPerSpawn = secondsPerSpawn;
		StartCoroutine("IncreaseDifficulty");
	}

	void Update() {
		timeSinceLastSpawn += Time.deltaTime;
		if(timeSinceLastSpawn > secondsPerSpawn) {
			Instantiate(Enemy, Vector3.zero, Quaternion.Euler(0,0,0));
			timeSinceLastSpawn = 0;
		}
	}
	
    IEnumerator IncreaseDifficulty()
    {
        yield return new WaitForSeconds(5);
        currentSecondsPerSpawn *= spawnIncreaseRate;
    }
}
