using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KarenClass : MonoBehaviour
{
    public List<string> KarenSpeech;
    public float waitTime = 45f;
    public CoffeeType iWantThis;
    private TMPro.TextMeshPro text;


    // Start is called before the first frame update
    void Start()
    {
        text = GetComponentInChildren<TextMeshPro>();

        if (KarenSpeech != null)
        {
            ChangeText(KarenSpeech[0]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeText(string newText)
    {
        if (text == null) return;
        text.text = newText;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Coffee")
        {
            Debug.Log("There's coffee");
            var coffee = collision.GetComponent<CoffeeClass>();
            Debug.Log(coffee.type);
            var marg = GameObject.Find("CoffeeAnchor").GetComponent<CoffeePickerUper>();

            if (coffee.type == iWantThis)
            {
                ChangeText(KarenSpeech[2]);
                Destroy(marg.Coffee);
                marg.isHoldingCoffee = false;
                ScoreManager.score++;
            }
            else
            {
                ChangeText(KarenSpeech[3]);
                Destroy(marg.Coffee);
                marg.isHoldingCoffee = false;
            }
        }
    }
}

