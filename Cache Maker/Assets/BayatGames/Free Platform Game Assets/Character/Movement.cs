using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 10;
    public float jump = 8;
    private Rigidbody2D rb;
    public int numJumps = 0;
    public int totalJumps = 3;
    Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveHorizontal * speed, rb.velocity.y);


        if ((numJumps < totalJumps) && Input.GetButtonDown("Jump")) // || Input.GetKeyDown(KeyCode.UpArrow))
        {
            numJumps++;
            rb.velocity = Vector2.up * jump;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {

        }
        numJumps = 0;
    }
}
