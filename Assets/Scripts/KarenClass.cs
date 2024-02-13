using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KarenClass : MonoBehaviour
{
    private TMPro.TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponentInChildren<TextMeshProUGUI>();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeText(string newText)
    {
        text.text = newText;
    }
}
