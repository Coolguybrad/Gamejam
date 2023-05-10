using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameMan;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Pickup") //if the player collides into a pickup
        {

            gameMan.GetComponent<ScoreManager>().currentScore++;
            Destroy(other.gameObject); //destroys the pickup object

        }
    }
}
