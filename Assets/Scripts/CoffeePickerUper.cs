using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeePickerUper : MonoBehaviour
{
    public GameObject Coffee;
    public KarenClass karenClass;

    public GameObject currentlyHeldCoffee;
    public bool isHoldingCoffee = false;
    public CoffeeType coffeeType;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && !isHoldingCoffee)
        {
            Coffee = Instantiate(currentlyHeldCoffee, transform.position, Quaternion.identity);
            Coffee.transform.parent = transform;
            isHoldingCoffee = true;
        }

        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("☆*.｡. o(≧▽≦)o .｡.*☆");
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coffee"))
        {
            currentlyHeldCoffee = collision.gameObject;
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {

    }
}