using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{

    public static bool forestActive=false;
    public static bool desertActive=true;

    public void BotonPlay() 

    {      
        SceneManager.LoadScene("EscogerCoche");            
    }

    

    public void BotonQuit()
    {
        Debug.Log("Game QUITED!");
        Application.Quit();
    }

    public void cambioBooleano() {
        forestActive = true;
        desertActive = false;
    }





}
