using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 5.0f;
    public GameObject self;

    void Update()
    {
        if (transform.position.x < -20f)
        {
            Destroy(self);
        }
    }

    private void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.fixedDeltaTime;
        
    }
}
