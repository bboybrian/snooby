using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;

    void Awake()
    {
        rb = gameObject.AddComponent<Rigidbody2D>() as Rigidbody2D;
        rb.bodyType = RigidbodyType2D.Dynamic;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // rb.velocity = new Vector2(0, -9.8f);
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Jump");
            changeVely(new Vector2(0.0f, 2.0f));
        }
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Left");
            changeVelx(new Vector2(-2.0f, 0.0f));
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Right");
            changeVelx(new Vector2(2.0f, 0.0f));
        }
    }
    void changeVelx(Vector2 v)
    {
        if (rb.velocity[0] < 3 && rb.velocity[0] > -3){
            rb.velocity = rb.velocity + v;
        }
    }
    void changeVely(Vector2 v)
    {
        if (rb.velocity[1] == 0){
            rb.velocity = rb.velocity + v;
        }
    }
}