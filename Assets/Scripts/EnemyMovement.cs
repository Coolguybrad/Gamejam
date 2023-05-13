using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 5.0f;

    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.fixedDeltaTime;
    }
}
