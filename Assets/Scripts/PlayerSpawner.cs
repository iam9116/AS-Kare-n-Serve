using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject maleBarrista;
    public GameObject femaleBarrista;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SpawnPlayer(int gender)
    {
        if (gender == 0)
        {
            Instantiate(maleBarrista);
        }else
        {
            Instantiate (femaleBarrista);
        }
    }
        
}
