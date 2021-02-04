using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusSpawner : MonoBehaviour
{
    [SerializeField] GameObject cactusPrefab;

    [SerializeField] float spawnTimer = 1;


    private void Update()
    {
        spawnTimer -= 1 * Time.deltaTime;
        if (spawnTimer < 0)
        {
            Vector3 position = new Vector3(gameObject.transform.position.x, (Random.Range(50f, -160f)), 0);  //Set the x on the spawners x and random y on the side
            GameObject cactusPowerUp = Instantiate(cactusPrefab, position, Quaternion.identity);
            spawnTimer = Random.Range(6,12);                                                                 //Random a new spawn timer
        }
    }
}
