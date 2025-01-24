using UnityEngine;

//To add background music to game.
namespace NanoWar
{
    public class Music : MonoBehaviour
    {
    private static Music instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Prevent destruction across scenes
        }
        else
        {
            Destroy(gameObject); // Ensure only one instance exists
        }
    }
    }
}
