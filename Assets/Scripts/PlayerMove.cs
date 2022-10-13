using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float PlayerSpeed;
    private float InputX;
    private Rigidbody2D rb2d;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
   
    void Update()
    {
        InputX = Input.GetAxisRaw("Horizontal");
        rb2d.velocity = new Vector2(InputX * PlayerSpeed, rb2d.velocity.y);
    }
}
