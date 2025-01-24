using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Splines;

//To spanw which type of object to spawn in set splines.
namespace NanoWar {
    public class EnemySpawner : MonoBehaviour {
        [SerializeField] List<EnemyType> enemyTypes;
        [SerializeField] int maxEnemies = 10;
        [SerializeField] float spawnInterval = 2f;
        
        List<SplineContainer> splines;
        EnemyFactory enemyFactory;
        List<GameObject> activeEnemies;
        
        float spawnTimer;

        void OnValidate() {
            splines = new List<SplineContainer>(GetComponentsInChildren<SplineContainer>());
        }

        void Start() {
            enemyFactory = new EnemyFactory();
            activeEnemies = new List<GameObject>();
        }

        void Update() {
            spawnTimer += Time.deltaTime;

            // Clean up destroyed enemies
            activeEnemies.RemoveAll(enemy => enemy == null);

            if (activeEnemies.Count < maxEnemies && spawnTimer >= spawnInterval) {
                SpawnEnemy();
                spawnTimer = 0f;
            }
        }

        void SpawnEnemy() {
            EnemyType enemyType = enemyTypes[Random.Range(0, enemyTypes.Count)];
            SplineContainer spline = splines[Random.Range(0, splines.Count)];
            
            GameObject enemy = enemyFactory.CreateEnemy(enemyType, spline);
            activeEnemies.Add(enemy);
        }
    }
}
