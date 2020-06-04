using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraGuia : MonoBehaviour
{

    private Transform cameraTarget1;
    private Transform lookTarget1;
    private float sSpeed = 10.0f;
    public Vector3 dist = new Vector3(-4, 2, 0);

    public GameObject coche1;
    public GameObject coche2;
    public GameObject coche3;


    //public Transform cam;
    //public GameObject vehiculo;
    private Vector3 desplazamiento = new Vector3(-4, 2, 0);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = vehiculo.transform.position + desplazamiento;
            
        //transform.LookAt(transform.position + cam.forward);
    
}

    
 

    void FixedUpdate()
    {

        if (rotacionCoche.acumulador == 2)
        {
            coche1.SetActive(true);
            cameraTarget1 = coche1.transform;
            lookTarget1 = coche1.transform;

            Vector3 dPos = cameraTarget1.position + dist;
            Vector3 sPos = Vector3.Lerp(transform.position, dPos, sSpeed * Time.deltaTime);
            transform.position = sPos;
            transform.LookAt(lookTarget1.position);


        }

        if (rotacionCoche.acumulador == 3)
        {
            coche2.SetActive(true);
            cameraTarget1 = coche2.transform;
            lookTarget1 = coche2.transform;

            Vector3 dPos = cameraTarget1.position + dist;
            Vector3 sPos = Vector3.Lerp(transform.position, dPos, sSpeed * Time.deltaTime);
            transform.position = sPos;
            transform.LookAt(lookTarget1.position);


        }

        if (rotacionCoche.acumulador == 1)
        {
            coche3.SetActive(true);
            cameraTarget1 = coche3.transform;
            lookTarget1 = coche3.transform;


            Vector3 dPos = cameraTarget1.position + dist;
            Vector3 sPos = Vector3.Lerp(transform.position, dPos, sSpeed * Time.deltaTime);
            transform.position = sPos;
            transform.LookAt(lookTarget1.position);


        }
    }
}