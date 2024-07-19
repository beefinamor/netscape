using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 1;
    private float direction;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        direction = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(direction * speed, rb.velocity.y);
    }
}
