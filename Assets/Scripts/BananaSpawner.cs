using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaSpawner : MonoBehaviour
{
    public GameObject prefab;
   
    public float initialSpawn;
    public float spawnRate;

    public float minX = 0f;
    public float maxX = 0f;
    public float minY = 0f;
    public float maxY = 0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBanana", initialSpawn, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnBanana()
    {
        float xPos = Random.Range(minX, maxX);
        float yPos = Random.Range(minY, maxY);

        //Figure out where to position banana
        Vector3 position = new Vector3(xPos, yPos, 0);

        //Spawn karen
        Instantiate(prefab, position, Quaternion.identity);
    }
}
