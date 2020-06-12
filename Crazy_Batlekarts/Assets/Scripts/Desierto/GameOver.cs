using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    public static bool GameIsPaused = false;

    public GameObject GmeOverMenu;
    public GameObject musica;
    public GameObject musica2;
    void Update()
    {
        if (HB_Kart.vida == 0)
        {
            
                Pause();
            musica.SetActive(false);
            musica2.SetActive(true);

        }
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("Menu");
    }


    public void Pause()
    {
        GmeOverMenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;

    }

    public void Restart()
    {
       
        SceneManager.LoadScene("EscogerCoche");


    }




}
