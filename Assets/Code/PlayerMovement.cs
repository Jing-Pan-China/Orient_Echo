using System.Collections;
using System.Collections.Generic;
using UnityEngine;




[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed=5f;
    private Rigidbody2D rb;
    private Vector2 input;





    void Awake()
{
    rb = GetComponent<Rigidbody2D>();  // 修正：使用尖括号，括号在后面
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
        rb.MovePosition(rb.position+input*moveSpeed*Time.fixedDeltaTime);
    }
}
