using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject gameMan;
    public GameObject objectToInstantiate;
    public float spawnInterval = 5f;

    void Start()
    {
        InvokeRepeating("SpawnObject", 0f, spawnInterval);
    }

    void SpawnObject()
    {
        Camera mainCamera = Camera.main;
        Vector3 cameraPosition = mainCamera.transform.position;
        float cameraHeight = 2f * mainCamera.orthographicSize;

        float randomY = Random.Range(cameraPosition.y - cameraHeight / 2, cameraPosition.y + cameraHeight / 2);
        Vector3 spawnPosition = new Vector3(10, randomY, 0);

        Instantiate(objectToInstantiate, spawnPosition, Quaternion.identity);
    }


}
