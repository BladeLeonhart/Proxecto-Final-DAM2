using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Victory : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject MenuVictoria;
    public GameObject musica;
    public GameObject musica2;

    void Update()
    {
        if (HB_Kart.vueltascontrol == 3)
        {

            Pause();
            musica.SetActive(false);
            musica2.SetActive(true);

        }
    }

    public void Pause()
    {
        MenuVictoria.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;

    }
    public void QuitMenu()
    {
        SceneManager.LoadScene("Menu");
    }

}
