using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;

    void Awake()
    {
        rb = gameObject.AddComponent<Rigidbody2D>() as Rigidbody2D;
        rb.bodyType = RigidbodyType2D.Kinematic;
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
            rb.velocity = new Vector2(0.0f, 2.0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Left");
            rb.velocity = new Vector2(-2.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.B))
        {
            Debug.Log("Right");
            rb.velocity = new Vector2(2.0f, 0.0f);
        }
    }
}