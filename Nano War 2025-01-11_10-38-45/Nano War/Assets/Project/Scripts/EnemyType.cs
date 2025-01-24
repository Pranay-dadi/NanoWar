using UnityEngine;

//To list properties of enemy types that are going to be spawned by the enemy spawner.
namespace NanoWar {
    [CreateAssetMenu(fileName = "EnemyType", menuName = "NanoWar/EnemyType", order = 0)]
    public class EnemyType : ScriptableObject {
        public GameObject enemyPrefab;
        public GameObject weaponPrefab;
        public float speed = 2f;
    }
}