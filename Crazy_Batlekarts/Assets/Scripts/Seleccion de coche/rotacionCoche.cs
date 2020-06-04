using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacionCoche : MonoBehaviour
{



    Vector3 targetRot;
    Vector3 currentAngle;

    int currentSelection;
    int totalCharacters=3;
    public GameObject Personaje1;
    public GameObject Personaje2;
    public GameObject Personaje3;

    public static int acumulador;


    void Start()
    {

        currentSelection=2;
        acumulador = currentSelection;

    }


    
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.RightArrow) && currentSelection<totalCharacters)
        {
            currentAngle = transform.eulerAngles;
            targetRot = targetRot + new Vector3(0, 90, 0);
            currentSelection++;
            acumulador = currentSelection;

        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) && currentSelection >1)
        {
            currentAngle = transform.eulerAngles;
            targetRot = targetRot - new Vector3(0, 90, 0);
            currentSelection--;
            acumulador = currentSelection;

        }

        if (currentSelection==2)
        {
            Personaje2.transform.Rotate(new Vector3(0, 0.5f, 0));

        }
        if (currentSelection == 1)
        {
            Personaje1.transform.Rotate(new Vector3(0, 0.5f, 0));

        }
        if (currentSelection == 3)
        {
            Personaje3.transform.Rotate(new Vector3(0, 0.5f, 0));

        }

        currentAngle = new Vector3(0,Mathf.LerpAngle(currentAngle.y,targetRot.y,2.0f*Time.deltaTime),0);
        transform.eulerAngles = currentAngle;
    }




}
