using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject maleBarrista;
    public GameObject femaleBarrista;

    private bool playerHasSpawned;

    // Start is called before the first frame update
    void Start()
    {
        playerHasSpawned = false;
    }

    public void SpawnPlayer(int gender)
    {
        if (playerHasSpawned == true) return;

        if (gender == 0)
        {
            Instantiate(maleBarrista);
        }else
        {
            Instantiate (femaleBarrista);
        }
        playerHasSpawned = true;
    }
        
}
