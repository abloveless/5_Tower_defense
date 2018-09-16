using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {
    [Range(0.1f, 10f)]
    [SerializeField] float secondsBetweenSpawn = 2f;
    [SerializeField] EnemyMovement enemyPrefab;

	// Use this for initialization
	void Start () {
        StartCoroutine(SpawnEnemies());
	}
	
    private IEnumerator SpawnEnemies()
    {
        while (true) // forever
        {
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(secondsBetweenSpawn);
        }
    }

}
