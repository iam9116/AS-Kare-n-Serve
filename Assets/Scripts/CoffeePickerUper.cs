using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoffeePickerUper : MonoBehaviour
{
    public GameObject Coffee;
    public KarenClass karenClass;

    public GameObject currentlyHeldCoffee;
    public bool isHoldingCoffee = false;
    public bool pickedupCoffee = false;
    public CoffeeType coffeeType;

    private KarenClass karenRef;
    private string interactingObj;
    public List<string> KarenSpeech;

    private TextMeshPro text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (isHoldingCoffee)
            {
                if (interactingObj == "Karen")
                {
                    DestroyCoffee();
                    karenRef.ObtainCoffee(coffeeType);
                    
                }
                if (interactingObj == "Trash")
                {
                    DestroyCoffee();
                }
            }
            else
            {
                if (interactingObj == "Coffee")
                {
                    Coffee = Instantiate(currentlyHeldCoffee, transform.position, Quaternion.identity);
                    Coffee.transform.parent = transform;
                    isHoldingCoffee = true;
                }
            }
        }
    }

    public void ChangeText(string newText)
    {
        if (text == null) return;
        text.text = newText;
    }
    public void DestroyCoffee()
    {
        Destroy(Coffee);
        isHoldingCoffee = false;
        //pickedupCoffee = false;
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