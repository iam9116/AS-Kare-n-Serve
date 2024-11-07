﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "CoffeeAnchor")
        {
            collision.gameObject.GetComponent<CoffeePickerUper>().DestroyCoffee();
        }
    }
}
