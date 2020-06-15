using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonGo : MonoBehaviour
{


    

    public void BotonIr()

    {       if (MainMenuScript.desertActive)
        {
            SceneManager.LoadScene("Desierto");
        }
            if (MainMenuScript.forestActive)
        {
            SceneManager.LoadScene("Bosque");
        }

        Application.Quit();     
    }

}
