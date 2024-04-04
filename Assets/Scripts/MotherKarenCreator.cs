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

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("MakeMoreKarens", initialSpawn, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MakeMoreKarens()
    {

        Debug.Log("Run");
        if (karenToSpawn <= 0) karenToSpawn = 1;
        if (radiusOfSpawn < 5f) radiusOfSpawn = 20f;

        for (int t = 0; t < karenToSpawn; t++)
        {
            //Get random number
            int randomIndex = Random.Range(0, karens.Length);

            //Get random karen based on random number
            KarenClass randomObject = karens[randomIndex];

            //Figure out where to position karen
            Vector3 position = new Vector3(Random.Range(-radiusOfSpawn, radiusOfSpawn), Random.Range(-radiusOfSpawn, radiusOfSpawn), 0);

            //Spawn karen
            Instantiate(karens[randomIndex], position, Quaternion.identity);
        }
    }

}
