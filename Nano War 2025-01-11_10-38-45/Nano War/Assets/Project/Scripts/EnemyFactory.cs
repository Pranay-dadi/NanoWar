using UnityEngine;
using UnityEngine.Splines;

//The generation part of the viruses when the enemy builder notifies to create the enemy.
namespace NanoWar {
    public class EnemyFactory {
        public GameObject CreateEnemy(EnemyType enemyType, SplineContainer spline) {
            EnemyBuilder builder = new EnemyBuilder()
                .SetBasePrefab(enemyType.enemyPrefab)
                .SetSpline(spline)
                .SetSpeed(enemyType.speed);

            GameObject enemy = builder.Build();

            // Assign destruction callback
            Enemy enemyComponent = enemy.GetComponent<Enemy>();
            if (enemyComponent != null) {
                enemyComponent.OnDestroyed = new UnityEngine.Events.UnityEvent();
                enemyComponent.OnDestroyed.AddListener(() => Debug.Log("Enemy destroyed."));
            }

            return enemy;
        }
    }
}
