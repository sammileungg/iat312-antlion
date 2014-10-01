/// generic code that spawns environment and power-ups 
/// source: http://unity3d.com/learn/tutorials/modules/beginner/live-training-archive/infinite-runner
/// at 33:43

using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

	///collection of objects to spawn
	public GameObject[] obj;
	///how fast to spawn (with 1f and 2f as default values, spawning randomly between 1 second and 2 seconds)
	public float spawnMin = 1f;
	public float spawnMax = 2f;

	///initialization, calls spawn function
	void Start () {
		Spawn();
	}

	///spawn function
	void Spawn()
	{
		///instantiates random object in array obj, at spawn location, with normal (no) rotation
		Instantiate(obj[Random.Range (0, obj.Length)], transform.position, Quaternion.identity);
		///invoke this to spawn at a random amount of time
		Invoke("Spawn", Random.Range (spawnMin, spawnMax));
	}

}