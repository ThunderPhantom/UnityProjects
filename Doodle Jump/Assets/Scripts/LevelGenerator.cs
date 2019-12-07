using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {
    public GameObject platformPrefab;

    public int numberOfPlatforms = 4000;
    public float levelWidth = 3f;
    public float minY = 3f;
    public float maxY = 6f;
    public float maxX = 3f, minX = -3f;
    private Vector3 spawnPosition;

	// Use this for initialization
	void Start () {
        spawnPosition = new Vector3(0, 0, 0);
        for(int i = 0; i < numberOfPlatforms; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(minX, maxX);
            Instantiate(platformPrefab, spawnPosition, transform.rotation);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
