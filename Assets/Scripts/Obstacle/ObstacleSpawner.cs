using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject obstaclePrefab;

    [SerializeField]
    private float spawnInterval = 2f;

    [SerializeField]
    private float spawnYPosition = 10f;

    [SerializeField]
    private float spawnRangeX = 5f;

    [SerializeField]
    private float obstacleSpeed = 5f;

    void Start()
    {
        InvokeRepeating("SpawnObstacle", 1f, spawnInterval);
    }

    private void Update()
    {
        speed();
    }

    void SpawnObstacle()
    {
        float spawnX = Random.Range(-spawnRangeX, spawnRangeX);
        Vector3 spawnPosition = new Vector3(spawnX, spawnYPosition, 0);
        GameObject obstacle = Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);
    }

    private void speed()
    {
        transform.Translate(Vector3.down * obstacleSpeed * Time.deltaTime);
    }
}

