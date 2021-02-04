using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D RB;
    private Vector2 movement;

    [SerializeField] private float speed = 2;


    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        movement.y = Input.GetAxisRaw("Vertical");
        movement.x = Input.GetAxisRaw("Horizontal");
    }


    private void FixedUpdate()
    {
        movement = movement.normalized;
        RB.MovePosition(RB.position + movement * speed * Time.fixedDeltaTime);
    }
}
