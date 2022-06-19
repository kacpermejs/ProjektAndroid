using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour
{

    protected Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Physics2D.gravity = new Vector2(Input.acceleration.x*40f, Input.acceleration.y*40f);
    }

    public void Reset()
    {
        transform.position = new Vector2(0f, 0f);
        rb.velocity = new Vector2(0f, 0f);

    }
}
