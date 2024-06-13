using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvilKarenCreator : MonoBehaviour
{
    public EvilKarenClass[] evilkarens;
    public int karenToSpawn;
    public float radiusOfSpawn;
    public float initialSpawn;
    public float spawnRate;

    private float xOffset = 0f;
    private float yOffset = 0f;

    private float maxY = 28f;
    private float minY = -89f;
    private float maxX = 165;
    private float minX = -170;
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
        /*
        if (karentospawn <= 0) karentospawn = 1;
        if (radiusofspawn < 1f) radiusofspawn = 20f;

        if (xoffset > 150f)
        {
            xoffset = 0f;
            yoffset += 50f;
        }

        if (yoffset > 80f)
        {
            yoffset = -92;
            xoffset = 0;
        }
        */



        for (int t = 0; t < karenToSpawn; t++)
        {
            //Get random number
            int randomIndex = Random.Range(0, evilkarens.Length);

            //Get random karen based on random number
            EvilKarenClass randomObject = evilkarens[randomIndex];


            //Figure out where to position banana
            Vector3 position = new Vector3(xOffset, yOffset, 0);

            //Spawn karen
            Instantiate(evilkarens[randomIndex], position, Quaternion.identity);

            xOffset = 0f;
            yOffset = 0f;

            xOffset += Random.Range(minX, maxX);
            yOffset += Random.Range(minY, maxY);
        }
    }
}
