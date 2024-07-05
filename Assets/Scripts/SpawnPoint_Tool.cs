using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint_Tool : MonoBehaviour
{
    public bool isOccupied = false;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
