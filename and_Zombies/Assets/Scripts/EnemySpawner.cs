using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;

    [SerializeField] float spawnTimer = 3;

    private void Update()
    {
        spawnTimer -= 1 * Time.deltaTime;
        if (spawnTimer < 0)
        {
            Vector3 position = new Vector3(gameObject.transform.position.x, (Random.Range(-100f, -360f)), 0);
            Instantiate(enemyPrefab, position, Quaternion.identity);
            spawnTimer = 3;
        }
    }
}
