using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D RB;
    private Vector2 movement;

    [SerializeField] private float speed = 2;


    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
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
