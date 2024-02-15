using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotherKarenCreator : MonoBehaviour
{
    public KarenClass[] karens;
    // Start is called before the first frame update
    void Start()
    {
        int randomIndex = Random.Range(0, karens.Length);
        KarenClass randomObject = karens[randomIndex];
        var position = new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), 0);
        Instantiate(randomObject, position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
