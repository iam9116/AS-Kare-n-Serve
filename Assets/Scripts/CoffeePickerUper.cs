using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeePickerUper : MonoBehaviour
{
    public GameObject Coffee;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coffee") && Input.GetButtonDown("Jump"))
        {
            Debug.Log("Cawfee");
            Debug.Log(other.gameObject.GetComponent<CoffeeClass>().type);

            Coffee = Instantiate(other.gameObject, new Vector3(25f, 0, 0), Quaternion.identity);
            Coffee.transform.parent = transform;

        }
    }
}
