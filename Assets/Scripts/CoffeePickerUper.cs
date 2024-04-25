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

    private KarenClass karenRef;
    private string interactingObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (interactingObj == "Coffee" && !isHoldingCoffee)
            {
                Coffee = Instantiate(currentlyHeldCoffee, transform.position, Quaternion.identity);
                Coffee.transform.parent = transform;
                isHoldingCoffee = true;
            }

            if (interactingObj == "Karen" && isHoldingCoffee)
            {
                karenRef.KarenTakesCoffee(this, coffeeType);
            }
        }
    }

    public void KarenSays(bool response)
    {
        if (response)
        {
            //If order is right code here
        }
        else
        {
            //If order is wrong code here
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        interactingObj = collision.gameObject.tag;

        switch (interactingObj)
        {
            case "Coffee":
                //Get a reference to the overlapped coffee object
                currentlyHeldCoffee = collision.gameObject;
                break;
            case "Karen":
                karenRef = collision.gameObject.GetComponent<KarenClass>();
                break;
        }
        
    }

    private void OnTriggerStay2D(Collider2D other)
    {

    }
}