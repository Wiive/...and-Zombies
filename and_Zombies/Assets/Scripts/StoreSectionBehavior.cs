using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreSectionBehavior : MonoBehaviour
{
    [SerializeField] float speed = 60;

    Rigidbody2D RB;

    public Transform leftPoint;
    public Transform rightPoint;

    private void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        RB.position += new Vector2(-speed * Time.deltaTime,0);
    }
}
