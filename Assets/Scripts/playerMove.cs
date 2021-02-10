using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    
    public Vector2 playerInput;
    private Rigidbody2D rb;
    public float moveSpeed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        playerInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        rb.velocity = playerInput.normalized * moveSpeed;
        if (playerInput == new Vector2(0,1))
        {
          gameObject.transform.rotation = Quaternion.Euler(0,0,0);
        }
        if (playerInput == new Vector2(1,0))
        {
            gameObject.transform.rotation = Quaternion.Euler(0,0,-90);
        }
        if (playerInput == new Vector2(1,1))
        {
            gameObject.transform.rotation = Quaternion.Euler(0,0,-45);
        }
        if (playerInput == new Vector2(1,-1))
        {
            gameObject.transform.rotation = Quaternion.Euler(0,0,-135);
        }
        if (playerInput == new Vector2(0,-1))
        {
            gameObject.transform.rotation = Quaternion.Euler(0,0,-180);
        }
        if (playerInput == new Vector2(-1,-1))
        {
            gameObject.transform.rotation = Quaternion.Euler(0,0,-225);
        }
        if (playerInput == new Vector2(-1,0))
        {
            gameObject.transform.rotation = Quaternion.Euler(0,0,-270);
        }
        if (playerInput == new Vector2(-1,1))
        {
            gameObject.transform.rotation = Quaternion.Euler(0,0,-315);
        }
        
    }

}
