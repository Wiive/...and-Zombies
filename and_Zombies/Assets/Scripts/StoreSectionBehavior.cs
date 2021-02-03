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

    public bool mainSection;

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

    public bool CheckLeftPointVisibility()
    {
        Vector2 cameraPosition = Camera.main.transform.position;
        Vector2 pointPosition = leftPoint.transform.position;

        float screenWidth = 640 / 2;

        if (pointPosition.x < (cameraPosition.x - screenWidth))
        {
            return false;
        }
        return true;              
    }
}
