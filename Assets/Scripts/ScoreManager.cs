using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {
        Rect rectangle = new Rect(10, 10, 200, 400);
        GUIStyle myStyle = new GUIStyle(GUI.skin.label);
        myStyle.fontSize = 50;
        GUI.Label(rectangle, "Score: " + score, myStyle);
    }
}
