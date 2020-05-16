using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonGo : MonoBehaviour
{
  
    


    public void BotonIr()

    {
     
        SceneManager.LoadScene("Desierto");
        Application.Quit();
    }

}
