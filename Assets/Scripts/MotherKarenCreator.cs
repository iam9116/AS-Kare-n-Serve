using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotherKarenCreator : MonoBehaviour
{
    public KarenClass[] karens;
    public int karenToSpawn;
    public float radiusOfSpawn;
    public float initialSpawn;
    public float spawnRate;
    
    private GameObject[] spawnPoints;
    
    // Start is called before the first frame update
    void Start()
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoint");
        InvokeRepeating("MakeKarens", initialSpawn, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MakeKarens()
    {
        //Get random number
        int randomIndex = Random.Range(0, karens.Length);

        //Random position
        int randomPosIndex = Random.Range(0, spawnPoints.Length);
        SpawnPoint_Tool spawnPoint = spawnPoints[randomPosIndex].GetComponent<SpawnPoint_Tool>();
        bool isOccupied = spawnPoint.isOccupied;

        if (isOccupied) return;

        Vector3 randomPos = spawnPoints[randomPosIndex].transform.position;

        //Spawn karen
        KarenClass karen = Instantiate(karens[randomIndex], randomPos, Quaternion.identity);
        karen.ToggleCheckPoint(spawnPoint);
        
    }
}
