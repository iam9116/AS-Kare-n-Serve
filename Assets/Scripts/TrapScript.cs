using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Invoke("BananaBurner", Random.Range(2, 8));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ScoreManager.score -= 1;
            Invoke("BananaBurner", 1f);
        }
    }
    private void BananaBurner()
    {
        Destroy(gameObject);
    }
}