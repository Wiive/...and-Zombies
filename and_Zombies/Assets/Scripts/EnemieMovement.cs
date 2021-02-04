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
    //Attack

    private void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        
        if (GameObject.FindGameObjectWithTag("Player") != null)             //Looking if a object with the "Player"-tag is in the scene
        {
            player = GameObject.FindGameObjectWithTag("Player");            //If it adds it to the GameObject Player
        }
        else
            Debug.LogError("Missing Player Prefans Objec in Scene");        //If not it makes our own error message to remeber to place a player in the scene

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
        //Mayeb implement a obeject pool of more 
    }

    private void MoveTowardsPlayer()
    {
        Vector2 direction = player.transform.position - transform.position;

        RB.velocity = direction * speed;

    }
    private void GotKilled()
    {
        isAlive = false;
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            var player = collision.gameObject;
            if (player.GetComponent<PlayerPickUp>().CactusPower())
            {
                GotKilled();
            }
            else
            {
                var manager = GameObject.Find("Managers");              //I hope we can name this object to something better later, just to try right now.
                if (manager != null)
                {
                    Health playerHealth = manager.GetComponent<Health>();
                    playerHealth.DamagePlayer(1);
                }
                else
                {
                    Debug.LogError("Missing Manager in scene");
                }
            }
        }
    }
}
