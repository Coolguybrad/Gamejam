using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject gameMan;
    [SerializeField]
    public GameObject [] platformPrefab;
    public int numberOfPlatforms = 10;
    public float minY = 0f;
    public float maxY = 10f;
    public float minX = -10f;
    public float maxX = 10f;
    
    // Start is called before the first frame update


    void Start()
    {
        SpawnPlatforms();
    }

    // Update is called once per frame
    void Update()
    {
        //if (gameMan.GetComponent<ScoreManager>().currentScore > 5)
        //{

        //}
    }

    void SpawnPlatforms()
    {
        float yPosition = minY;


        for (int i = 0; i < numberOfPlatforms; i++)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(minX, maxX), yPosition, 0);
            Instantiate(platformPrefab[Random.Range(0, platformPrefab.Length)], spawnPosition, Quaternion.identity);
            yPosition += 2f;
        }
    }
}
