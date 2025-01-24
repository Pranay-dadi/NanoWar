using UnityEngine;
using UnityEngine.Events;

//Actions to be taken when a projectile hits the enemy
namespace NanoWar {
    public class Enemy : Plane {
        [SerializeField] GameObject explosionPrefab;

        public UnityEvent OnDestroyed;

        protected override void Die() {
            GameManager.Instance.AddScore(10);
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);

            OnDestroyed?.Invoke(); // Notify the spawner
            Destroy(gameObject);
        }
    }
}
