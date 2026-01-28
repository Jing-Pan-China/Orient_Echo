using System.Collections;
using System.Collections.Generic;
using UnityEngine;




[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    
    public float moveSpeed=5f;
    private Rigidbody2D rb;
    private Vector2 input;





    void Awake()
{
    rb = GetComponent<Rigidbody2D>();  
}

    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        input.x =Input.GetAxisRaw("Horizontal");
        input.y=Input.GetAxisRaw("Vertical");
        input=input.normalized;
    }


    void FixedUpdate()
    {
        // rb.MovePosition(rb.position+input*moveSpeed*Time.fixedDeltaTime);
        rb.velocity = input * moveSpeed;

    }
}
