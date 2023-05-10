using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIInteract : MonoBehaviour
{
    public GameObject gameMan;
    public TMP_Text txtScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        txtScore.text = "Score: " + gameMan.GetComponent<ScoreManager>().currentScore;
    }
}
