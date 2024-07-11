using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class KarenClass : MonoBehaviour
{
    public List<string> KarenSpeech;
    public CoffeeType iWantThis;
    public GameObject karen;

    //Tweakables
    public float waitTime = 45f;
    public int sanityToLose = 10;

    private TMPro.TextMeshPro text;
    private SpawnPoint_Tool spawnPoint;

    public bool hasCoffee;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponentInChildren<TextMeshPro>();
        
        if (KarenSpeech != null)
        {
            ChangeText(KarenSpeech[0]);
        }

        Invoke("KarenWarning", 15f);
    }

    void OnDestroy()
    {
        spawnPoint.isOccupied = false;
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

    public void ToggleCheckPoint(SpawnPoint_Tool spawnCheck)
    {
        spawnPoint = spawnCheck;
        spawnPoint.isOccupied = true;
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
}