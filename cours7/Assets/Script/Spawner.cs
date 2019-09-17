using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    public float spawnRate = 1;
    private SpawnPoint[] spawnPoints;
    public GameObject ennemiPrefab;
    private float timeLeftBeforeSpawmn = 0;

	// Use this for initialization
	void Start () {
        spawnPoints = FindObjectsOfType<SpawnPoint>();
        timeLeftBeforeSpawmn = 1 / spawnRate;
	}
	
	// Update is called once per frame
	void Update () {
        UpdateSpawn();

    }

    private void UpdateSpawn()
    {
        timeLeftBeforeSpawmn -= Time.deltaTime;
        if (timeLeftBeforeSpawmn < 0)
        {
            SpawnCube();
            timeLeftBeforeSpawmn = 1 / spawnRate;
        }
    }

    private void SpawnCube()
    {
        int countSpawnPoint = spawnPoints.Length;
        int randomPointIndex = Random.Range(0, countSpawnPoint);
        SpawnPoint spawnPointRandomlySelected = spawnPoints[randomPointIndex];
        GameObject newCube = Instantiate(ennemiPrefab, spawnPointRandomlySelected.GetPosition(), spawnPointRandomlySelected.transform.rotation);
    }
}
