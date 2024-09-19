using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
//using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class KarenClass : MonoBehaviour
{
    public List<string> KarenSpeech;
    public CoffeeType iWantThis;
    public GameObject karen;

    public SpriteRenderer sRenderer;
    public Color originalColour;
    public Color shiftedColour;

    //Tweakables
    public float waitTime = 25f;
    public int sanityToLose = 10;

    private TextMeshPro text;
    private SpawnPoint_Tool spawnPoint;
    private float incrementBuffer = 0f;

    public bool hasCoffee;

    private BoxCollider2D boxCollider;
    // Start is called before the first frame update
    void Start()
    {

        text = GetComponentInChildren<TextMeshPro>();
        
        if (KarenSpeech != null)
        {
            ChangeText(KarenSpeech[0]);
        }

        Invoke("KarenWarning", 12f);

        boxCollider = GetComponent<BoxCollider2D>();

        InvokeRepeating("ColourShift", 1f, 1.5f);
    }

    void OnDestroy()
    {
        spawnPoint.isOccupied = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ColourShift()
    {
        Color newColor = Vector4.Lerp(originalColour, shiftedColour, incrementBuffer);
        incrementBuffer += 1f/24f;

        if (sRenderer != null)
        {
            newColor.a = 1;
            sRenderer.color = newColor;
        }
    }



    public void ChangeText(string newText)
    {
        if (text == null) return;
        text.text = newText;
    }

    public void ToggleCheckPoint(SpawnPoint_Tool spawnCheck)
    {
        spawnPoint = spawnCheck;
        spawnPoint.isOccupied = true;
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Coffee")
        {
            Debug.Log("There's coffee");
            var coffee = collision.GetComponent<CoffeeClass>();
            Debug.Log(coffee.type);
            var marg = GameObject.Find("CoffeeAnchor").GetComponent<CoffeePickerUper>();
            if (coffee.type == iWantThis && marg.isHoldingCoffee)
            {
                ChangeText(KarenSpeech[2]);
                Destroy(marg.Coffee);
                boxCollider.enabled = false;
                marg.isHoldingCoffee = false;                
                ScoreManager.score++;
                hasCoffee = true;
                Invoke("KarenBurner", 2f);
                
            }
            else
            {
                ChangeText(KarenSpeech[3]);
                Destroy(marg.Coffee);
                marg.isHoldingCoffee = false;
                hasCoffee = false;
                ScoreManager.sanity -= 20;
            }
            SceneLoader();
        }
    }

    private void KarenWarning()
    {
        ChangeText(KarenSpeech[1]);
        Invoke("KarenBurner", waitTime);
    }

    private void KarenBurner()
    {
        Destroy(karen);
    }

    private void SceneLoader()
    {
        if (ScoreManager.sanity == 0)
        {
            SceneManager.LoadScene(4);
        }

        if (ScoreManager.score == 10)
        {
            SceneManager.LoadScene(5);
        }
    }

    void DestroyCoffee()
    {
       
    }
}