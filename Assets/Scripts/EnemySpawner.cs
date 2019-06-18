using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    private float spawnX;
    private float spawnZ;

    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        spawnX = transform.localPosition.x;
        spawnZ = transform.localPosition.z;

        SpawnEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnEnemy()
    {
        GameObject enemyInstance;
        enemyInstance = Instantiate(enemy);
        enemyInstance.transform.position = new Vector3(transform.position.x + Random.Range(-spawnX, spawnX), 0, 
            transform.position.z + Random.Range(-spawnZ, spawnZ));
    }
}
