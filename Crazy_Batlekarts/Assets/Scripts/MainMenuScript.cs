using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{

    public void BotonPlay() 

    {
        SceneManager.LoadScene("EscogerCoche");
    }

    

    public void BotonQuit()
    {
        Debug.Log("Game QUITED!");
        Application.Quit();
    }





}
