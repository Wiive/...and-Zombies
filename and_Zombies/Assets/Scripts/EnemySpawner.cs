using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;

    [SerializeField] float spawnTimer = 3;

    public enum SpawnSide { horizontal, vertical}
    public SpawnSide spawnSide;

    private void Update()
    {
        spawnTimer -= 1 * Time.deltaTime;
        if ((spawnTimer < 0) && (spawnSide == SpawnSide.vertical))
        {
            Vector3 position = new Vector3(gameObject.transform.position.x, (Random.Range(-100f, -360f)), 0);
            Instantiate(enemyPrefab, position, Quaternion.identity);
            spawnTimer = 3;
        }

        else if ((spawnTimer < 0) && (spawnSide == SpawnSide.horizontal))
        {
            Vector3 position = new Vector3(Random.Range(-250f, 250f), gameObject.transform.position.y, 0);
            Instantiate(enemyPrefab, position, Quaternion.identity);
            spawnTimer = 3;
        }
    }
}
