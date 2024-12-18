﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static int score = 0;
    public static int sanity = 100;

    private void Start()
    {
        score = 0;
        sanity = 100;
    }
    private void OnGUI()
    {
        Rect rectangle = new Rect(175, 10, 200, 400);
        GUIStyle myStyle = new GUIStyle(GUI.skin.label);
        myStyle.fontSize = 50;
        GUI.Label(rectangle, "Score: " + score, myStyle);

        rectangle = new Rect(175, 100, 300, 500);
        myStyle = new GUIStyle(GUI.skin.label);
        myStyle.fontSize = 50;
        GUI.Label(rectangle, "Sanity%:" + sanity, myStyle);
    }
}
