using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

	public Transform[] spawns;
	public GameObject[] obstacles;
	private Vector3 desiredPosition;
	private GameObject desiredObstacle;
	public float SecPerSpawn;
	private float spawnCounter = 0.0f;

	void Update() {
		if(spawnCounter >= SecPerSpawn) {
			Instantiate(PickObstacle(), PickPosition(), Quaternion.identity);
			spawnCounter = 0;
		} else {
			spawnCounter += Time.deltaTime;
		}
	}

	GameObject PickObstacle() {
		int rand = Random.Range(0, obstacles.Length + 1);
		switch(rand) {
			case 0:
				desiredObstacle = obstacles[0];
			break;
			case 1:
				desiredObstacle = obstacles[1];
			break;
			default:
			break;
		}
		return desiredObstacle;
	}

	Vector3 PickPosition() {
		int rand = Random.Range(0, obstacles.Length + 1);
		switch(rand) {
			case 0:
				desiredPosition = spawns[0].position;
			break;
			case 1:
				desiredPosition = spawns[1].position;
			break;
			case 2:
				desiredPosition = spawns[2].position;
			break;
			default:
			break;
		}
		return desiredPosition;
	}



}
