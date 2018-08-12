using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

	public GameObject Enemy;
	public float secondsPerSpawn = 5f;
	public float spawnIncreaseRate = 0.9f;
	public float minSpawnDistance = 30.0f;
	public float maxSpawnDistance = 100.0f;

	GameObject player;
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
		if(!player) { return; }
		Vector3 fwd = player.transform.forward.normalized;
		Vector3 randPos = fwd * (maxSpawnDistance - minSpawnDistance) + fwd * minSpawnDistance;

		randPos = RotateVector2D(randPos, Random.Range(-75f, 75f));

		Instantiate(Enemy, transform.position + randPos, Quaternion.Euler(0,0,0));
	}
	
    IEnumerator IncreaseDifficulty() {
        yield return new WaitForSeconds(5);
        currentSecondsPerSpawn *= spawnIncreaseRate;
    }

	private Vector3 RotateVector2D(Vector3 oldDirection, float angle)   
	{
		float newX = Mathf.Cos(angle*Mathf.Deg2Rad) * (oldDirection.x) - Mathf.Sin(angle*Mathf.Deg2Rad) * (oldDirection.z);   
		float newY = oldDirection.y;
		float newZ = Mathf.Sin(angle*Mathf.Deg2Rad) * (oldDirection.x) + Mathf.Cos(angle*Mathf.Deg2Rad) * (oldDirection.z);  
		return new Vector3(newX, newY, newZ);   
	}
}
