using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreSectionBehavior : MonoBehaviour
{
    [SerializeField] float speed = 60;

    Rigidbody2D RB;

    public GameObject leftPoint;
    public GameObject rightPoint;
    SpriteRenderer spriteRendererLeft;
    SpriteRenderer spriteRendererRight;

    private void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        spriteRendererLeft = leftPoint.GetComponent<SpriteRenderer>();
        spriteRendererRight = rightPoint.GetComponent<SpriteRenderer>();
        spriteRendererLeft.enabled = false;
        spriteRendererRight.enabled = false;
    }

    private void Update()
    {
        RB.position += new Vector2(-speed * Time.deltaTime,0);
    }
}
