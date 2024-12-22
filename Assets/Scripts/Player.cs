using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private GameManager gameData;
    public float Speed;
    private float JumpVal = 5;
    private Rigidbody2D rb;

    private void Start()
    {
        gameData = GameObject.FindGameObjectWithTag("Data").GetComponent<GameManager>();
        rb = GetComponent<Rigidbody2D>();
    }

    //private void FixedUpdate()
    //{
    //    float horizontal = Input.GetAxisRaw("Horizontal");

    //    Vector2 movement = new Vector2(horizontal,0);

    //    rb.velocity = movement * Speed;
    //}

    private void Update()
    {
        Move();
    }

    void Move()
    {
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(new Vector2(-Speed * Time.deltaTime, 0));
        }

        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(new Vector2(Speed * Time.deltaTime, 0));
        }

        if (Input.GetKey(KeyCode.Space))
        {
            //æ∆¿Ã≈€ ±‚πÕ
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            rb.AddForce(Vector2.up * JumpVal, ForceMode2D.Impulse);
        }
    }
}
