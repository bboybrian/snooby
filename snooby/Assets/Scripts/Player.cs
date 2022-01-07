using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveSpeed = 2.0f;
    private float jumpSpeed = 5.0f;

    void Awake()
    {
        rb = gameObject.AddComponent<Rigidbody2D>() as Rigidbody2D;
        rb.bodyType = RigidbodyType2D.Dynamic;
        rb.freezeRotation = true;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Jump");
            rb.velocity = new Vector2(0.0f, jumpSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Left");
            rb.velocity = new Vector2(-moveSpeed, 0.0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Right");
            rb.velocity = new Vector2(moveSpeed, 0.0f);
        }
    }
}