using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Level01_PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody rb; 
    private Vector2 input;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();  
    }

    // Update is called once per frame
    void Update()
    {
        // 获取输入
        input.x = Input.GetAxisRaw("Horizontal"); 
        input.y = Input.GetAxisRaw("Vertical");  
    }

    void FixedUpdate()
    {
       
        Vector3 movement = new Vector3(input.x, 0, input.y) * moveSpeed * Time.fixedDeltaTime;


        //rb.velocity = movement;

        transform.position += movement;


    }
}