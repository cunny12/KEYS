using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float Speed =5f;
    public Rigidbody2D rb;
    public Animator animator;
    Vector2 movement;


    void Update()
    {
       if (Input.GetKey (KeyCode.LeftShift))
           Speed = 7f;
        else
           Speed = 5f;



        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

    
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * Speed* Time.fixedDeltaTime);
  }
}
