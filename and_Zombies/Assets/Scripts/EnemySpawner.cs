using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;

    [SerializeField] float spawnTimer = 3;

    public enum SpawnSide { horizontal, vertical}                                            //Decides if the Zombies gonna spawn on the right side or under the screen
    public SpawnSide spawnSide;

    private void Update()
    {
        spawnTimer -= 1 * Time.deltaTime;
        if ((spawnTimer < 0) && (spawnSide == SpawnSide.vertical))
        {
            Vector3 position = new Vector3(gameObject.transform.position.x, (Random.Range(-100f, -360f)), 0);  //Sets a random y position from the spawners x position
            Instantiate(enemyPrefab, position, Quaternion.identity);
            spawnTimer = 3;
        }

        else if ((spawnTimer < 0) && (spawnSide == SpawnSide.horizontal))
        {
            Vector3 position = new Vector3(Random.Range(-250f, 250f), gameObject.transform.position.y, 0);    //Sets a random x position from the spawners y position
            Instantiate(enemyPrefab, position, Quaternion.identity);
            spawnTimer = 3;
        }
    }
}
