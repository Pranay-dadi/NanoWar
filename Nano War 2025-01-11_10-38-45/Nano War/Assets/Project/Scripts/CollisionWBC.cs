using UnityEngine;
using UnityEngine.SceneManagement; 

namespace NanoWar{



public class CollisionWBC : MonoBehaviour
{
    // Make sure the player has a tag "Player" to identify it
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Collision with Player detected!");
            // Load the Game Over screen
            SceneManager.LoadScene("GameOverScene");
        }
    }

    // Alternatively, you can use OnTriggerEnter if you use triggers instead of colliders
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Trigger collision with Player detected!");
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
}