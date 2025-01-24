using UnityEngine;

namespace NanoWar {
    public class HealthBoost : MonoBehaviour {
        [SerializeField] int healthIncreaseAmount = 20; // Amount of health to increase

        void OnCollisionEnter(Collision collision) {
            if (collision.gameObject.CompareTag("Player")) {
                Player player = collision.gameObject.GetComponent<Player>();
                if (player != null) {
                    player.OnCollisionWithHealthBoost(healthIncreaseAmount);
                    Destroy(gameObject); // Remove the health boost object after collision
                }
            }
        }
    }
}
