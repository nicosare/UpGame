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
        rb.isKinematic = true;
    }


    public void JumpLeft()
    {
        rb.isKinematic = false;
        rb.velocity = new Vector2(-1, 2.5f) * force;
    }

    public void JumpRight()
    {
        rb.isKinematic = false;
        rb.velocity = new Vector2(1, 2.5f) * force;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
            JumpLeft();
        else if (Input.GetKeyDown(KeyCode.D))
            JumpRight();
    }
}
