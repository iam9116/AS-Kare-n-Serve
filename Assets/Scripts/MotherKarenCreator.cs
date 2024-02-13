using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotherKarenCreator : MonoBehaviour
{
    public GameObject karen;

    private List<GameObject> KarenList;

    // Start is called before the first frame update
    void Start()
    {
        KarenList = new List<GameObject>();

        GameObject newKaren = Instantiate(karen, new Vector3(0, 0, 0), Quaternion.identity);
        
        KarenList.Add(newKaren);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
