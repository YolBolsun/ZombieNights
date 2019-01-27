using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyManager : MonoBehaviour {

    public GameObject enemy1;
    public Transform target;
    public List<Transform> spawnLocations;
    //public Transform spawnLocation;
    public float spawnPerSecond;
    float spawnDelay;
    float lastSpawn = 0;
    float spawnMin;
    float spawnMax;
    public float spawnRange;
    float currentDelay;

	// Use this for initialization
	void Start () {
        spawnDelay = 1 / spawnPerSecond;
        spawnMin = spawnDelay - (.5f * spawnRange);
        if(spawnMin < 0)
        {
            spawnMin = 0;
        }
        spawnMax = spawnDelay + (.5f * spawnRange);
        currentDelay = spawnDelay;
	}
	
	// Update is called once per frame
	void Update () {
        lastSpawn += Time.deltaTime;
	    if(lastSpawn > currentDelay)
        {
            int spawnNumber = Random.Range(0, spawnLocations.Count);
            GameObject clone = (GameObject)GameObject.Instantiate(enemy1,spawnLocations[spawnNumber].position,Quaternion.identity);
            clone.GetComponent<Enemy>().target = target;
            lastSpawn = 0;
            currentDelay = Random.Range(spawnMin, spawnMax);
        }
	}
}
