using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1); // reloads demo level
    }
}
