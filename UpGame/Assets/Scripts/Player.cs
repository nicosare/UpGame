using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float force;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    public void JumpLeft()
    {
        rb.velocity = new Vector2(-1, 2.5f) * force;
    }

    public void JumpRight()
    {
        rb.velocity = new Vector2(1, 2.5f) * force;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
            JumpLeft();
        else if (Input.GetKeyDown(KeyCode.D))
            JumpRight();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Obstacle")
            Destroy(gameObject);
    }
}
