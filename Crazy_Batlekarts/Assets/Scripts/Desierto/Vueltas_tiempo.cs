using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vueltas_tiempo : MonoBehaviour
{

    public Text contador;
    public Text contadorvueltas;

    private float tiempo = 0f;
    public static int vueltas = 0;
  
   
    void Start()
    {

        contador.text = " " + tiempo;
        contadorvueltas.text = " " + vueltas;

    }


    void Update()
    {
        tiempo += Time.deltaTime;
        contador.text = " " + tiempo.ToString("f0");
        contadorvueltas.text = " " + vueltas.ToString();

    }

  



}
