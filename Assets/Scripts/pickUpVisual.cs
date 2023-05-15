using UnityEngine;

public class pickUpVisual : MonoBehaviour
{
    public float spinSpeed = 100f;
    public float bobSpeed = 1f;
    public float bobHeight = 0.5f;

    private Vector3 startingPosition;

    void Start()
    {
        startingPosition = transform.position;
    }

    void Update()
    {
        // Spin the object
        transform.Rotate(Vector3.forward, spinSpeed * Time.deltaTime);

        // Bob the object up and down
        float newY = startingPosition.y + Mathf.Sin(Time.time * bobSpeed) * bobHeight;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }

}

