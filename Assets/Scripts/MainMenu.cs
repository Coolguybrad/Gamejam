using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    [SerializeField] private GameObject refCanvas;
    [SerializeField] private GameObject instructionsCanvas;

    public void LoadGame()
    {
        SceneManager.LoadScene(1); //loads game level
    }

    public void QuitGame()
    {
        Application.Quit();                 //quits game
    }

    public void ShowInstructionList()
    {
        instructionsCanvas.SetActive(true);     //shows instructions
    }

    public void HideInstructionList()
    {
        instructionsCanvas.SetActive(false);    //hides instructions
    }

}