using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBetweenTwoPoints : MonoBehaviour
{
    public Transform startMarker;
    public Transform endMarker;
    public float duration = 1.0f;

    private float startTime;
    private Vector3 startPosition;
    private Vector3 endPosition;

    void Start()
    {
        // Cache the start position and end position
        startPosition = startMarker.position;
        endPosition = endMarker.position;

        // Set the start time to the current time
        startTime = Time.time;
    }

    void Update()
    {
        // Calculate the elapsed time since the start time
        float elapsedTime = Time.time - startTime;

        // Calculate the current progress (between 0 and 1) based on elapsed time and duration
        float progress = Mathf.PingPong(elapsedTime / duration, 1.0f);

        // Lerp the position between the start and end positions based on progress
        transform.position = Vector3.Lerp(startPosition, endPosition, progress);
    }
}
