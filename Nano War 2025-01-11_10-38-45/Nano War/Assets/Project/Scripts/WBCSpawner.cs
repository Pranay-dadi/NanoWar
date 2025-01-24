using UnityEngine;

namespace NanoWar
{
    

public class WBCSpawner : MonoBehaviour
{
        public GameObject objectToSpawn;
    public float spawnInterval = 2f;
    private float nextSpawnTime;
    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        if (Time.time > nextSpawnTime)
        {
            nextSpawnTime = Time.time + spawnInterval;

            // Calculate camera bounds
            float cameraWidth = mainCamera.orthographicSize * mainCamera.aspect;
            float cameraHeight = mainCamera.orthographicSize;
            float cameraLeft = mainCamera.transform.position.x - cameraWidth;
            float cameraRight = mainCamera.transform.position.x + cameraWidth;
            float cameraTop = mainCamera.transform.position.y + cameraHeight; 

            // Generate random position within camera width
            float randomX = Random.Range(cameraLeft, cameraRight);

            // Spawn above the camera
            float spawnY = cameraTop + cameraHeight + 10f; 

            // Instantiate object
            Instantiate(objectToSpawn, new Vector3(randomX, spawnY, 0), Quaternion.identity);
        }
    }
}
}