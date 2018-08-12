using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

	public GameObject Enemy;
	public float secondsPerSpawn = 5f;
	public float spawnIncreaseRate = 0.9f;
	public float minSpawnDistance = 30.0f;
	public float maxSpawnDistance = 100.0f;

	float currentSecondsPerSpawn;
	float timeSinceLastSpawn = 0;

	void Start () {
		player = GameObject.FindWithTag("Player");
		currentSecondsPerSpawn = secondsPerSpawn;
		StartCoroutine("IncreaseDifficulty");
	}

	void Update() {
		timeSinceLastSpawn += Time.deltaTime;
		if(timeSinceLastSpawn > secondsPerSpawn) {
			SpawnEnemy();
			timeSinceLastSpawn = 0;
		}
	}

	public void SpawnEnemy() {
		Vector3 randPos = Random.insideUnitCircle  * (maxSpawnDistance - minSpawnDistance);
		randPos = new Vector3(randPos.x + Mathf.Sign(randPos.x) * minSpawnDistance, 0, randPos.y + Mathf.Sign(randPos.y) * minSpawnDistance);
		randPos.x += transform.position.x;
		randPos.z += transform.position.z;

		Instantiate(Enemy, randPos, Quaternion.Euler(0,0,0));
	}
	
    IEnumerator IncreaseDifficulty() {
        yield return new WaitForSeconds(5);
        currentSecondsPerSpawn *= spawnIncreaseRate;
    }
}
