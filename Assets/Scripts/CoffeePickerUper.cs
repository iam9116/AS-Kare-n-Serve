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
    public string coffeeType;

    private KarenClass karenRef;
    private string interactingObj;
    public List<string> KarenSpeech;

    private TextMeshPro text;

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
                if (interactingObj == "Black" || interactingObj == "Latte" || interactingObj == "IceCaramel" || interactingObj == "Espresso")
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
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        interactingObj = collision.gameObject.tag;

        switch (interactingObj)
        {
            case "Black":
            case "Latte":
            case "Espresso":
            case "IceCaramel":
                //Get a reference to the overlapped coffee object
                currentlyHeldCoffee = collision.gameObject;
                coffeeType = collision.gameObject.tag;
                break;
            case "Karen":
                karenRef = collision.gameObject.GetComponent<KarenClass>();
                break;
        }
    }
}