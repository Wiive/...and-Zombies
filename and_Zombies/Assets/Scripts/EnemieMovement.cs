using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemieMovement : MonoBehaviour
{
    [SerializeField] float speed = 1.5f;
    Rigidbody2D RB;
    public bool isAlive = true;

    GameObject player;

    //Spawn
    //Looking for player
    //Go towards player
    //Die
    //Attack

    private void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }
        else
            Debug.LogError("Missing Player Prefans Objec in Scene");
        
    }

    private void Update()
    {
        if(isAlive)
        {
            MoveTowardsPlayer();
        }
    }

    private void Spawn()
    {

    }

    private void MoveTowardsPlayer()
    {
        Vector2 direction = player.transform.position - transform.position;

        RB.velocity = direction * speed;

    }


    private void GotKilled()
    {
        isAlive = false;
    }
}
