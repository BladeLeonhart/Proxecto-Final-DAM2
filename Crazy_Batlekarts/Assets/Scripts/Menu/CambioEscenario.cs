using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioEscenario : MonoBehaviour
{


    public GameObject bosque;
    
    public static int acum_escena;


    public void escenabosque()
    {

        acum_escena = 1;
    }

    public void escenadesierto()
    {

        acum_escena = 2;
    }


}
