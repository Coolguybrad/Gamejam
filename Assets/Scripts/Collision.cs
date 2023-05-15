using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{

    public GameObject seedEnd;
    public GameObject flowerEnd;
    public GameObject treeEnd;

    public GameObject cam;

    // Start is called before the first frame update
    public GameObject gameMan;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Pickup") //if the player collides into a pickup
        {

            gameMan.GetComponent<ScoreManager>().currentScore++;
            Destroy(other.gameObject); //destroys the pickup object

        }

        if(other.gameObject.tag == "Player")
        {
            if(gameMan.GetComponent<ScoreManager>().currentScore<5)
            {
                seedEnd.SetActive(true);                
            }
            else if(gameMan.GetComponent<ScoreManager>().currentScore < 10)
            {
                flowerEnd.SetActive(true);
            }
            else
            {
                treeEnd.SetActive(true) ;
            }

            other.gameObject.SetActive(false);
            cam.SetActive(true);
        }
    }
}
