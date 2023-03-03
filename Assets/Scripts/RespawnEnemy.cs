using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnEnemy : MonoBehaviour
{
    [SerializeField] private Transform xRangeLeft;
    [SerializeField] private Transform xRangeRight;

    [SerializeField] private Transform zRangeUp;
    [SerializeField] private Transform zRangeDown;

    [SerializeField] private float timeSpawn = 1f;
    [SerializeField] private float repeatSpawnRate = 3f;
    [SerializeField] private int enemyType;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemies", timeSpawn, repeatSpawnRate);
    }

    public void SpawnEnemies()
    {
        Vector3 spawnPosition = new Vector3(0, 0, 0);

        spawnPosition = new Vector3(Random.Range(xRangeLeft.position.x, xRangeRight.position.x), 0, Random.Range(zRangeDown.position.z, zRangeUp.position.z));

        GameObject enemy = PoolManager.Instance.GetPooledObjects(Random.Range(1, 3), spawnPosition, Quaternion.identity);

        enemy.SetActive(true);
        
    }
}
