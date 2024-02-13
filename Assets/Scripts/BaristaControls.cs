using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaristaControls : MonoBehaviour
{
    public float speed = 10f;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        speed *= 1000f;
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0.0f);
        rb.velocity = movement * speed * Time.deltaTime;
    }
}
