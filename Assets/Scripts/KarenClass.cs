using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KarenClass : MonoBehaviour
{
    public List<string> KarenSpeech;
    public float waitTime = 45f;

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
}
