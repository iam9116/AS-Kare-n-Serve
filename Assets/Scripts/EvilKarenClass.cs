using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvilKarenClass : MonoBehaviour
{
    public GameObject EvilKaren;
    // Start is called before the first frame update
    void Start()
    {
        
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
            Invoke("EvilKarenBurner", 1f);
        }
    }
    private void EvilKarenBurner()
    {
        Destroy(EvilKaren);
    }
}