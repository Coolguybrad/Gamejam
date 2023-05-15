using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Collision : MonoBehaviour
{

    public GameObject seedEnd;
    public GameObject flowerEnd;
    public GameObject treeEnd;
    public GameObject seedEndCanvas;
    public GameObject flowerEndCanvas;
    public GameObject treeEndCanvas;

    public GameObject cam;

    // Start is called before the first frame update
    public GameObject gameMan;

    public UnityEvent onPickUp = new UnityEvent();

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Pickup") //if the player collides into a pickup
        {

            gameMan.GetComponent<ScoreManager>().currentScore++;
            onPickUp.Invoke();
            Destroy(other.gameObject); //destroys the pickup object

        }

        if(other.gameObject.tag == "Player")
        {
            if(gameMan.GetComponent<ScoreManager>().currentScore<5)
            {
                seedEnd.SetActive(true);
                seedEndCanvas.SetActive(true);
            }
            else if(gameMan.GetComponent<ScoreManager>().currentScore < 10)
            {
                flowerEnd.SetActive(true);
                flowerEndCanvas.SetActive(true );
            }
            else
            {
                treeEnd.SetActive(true) ;
                treeEndCanvas.SetActive(true);
            }

            other.gameObject.SetActive(false);
            cam.SetActive(true);
        }
    }
}
