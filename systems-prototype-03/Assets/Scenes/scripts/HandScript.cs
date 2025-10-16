using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEditor.Callbacks;

public class HandScript : MonoBehaviour
{
    private Rigidbody2D rb;
    public float num;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.angularVelocity = num;
    }
}
