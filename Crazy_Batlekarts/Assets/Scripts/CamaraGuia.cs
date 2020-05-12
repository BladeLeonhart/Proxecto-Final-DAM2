using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraGuia : MonoBehaviour
{
    public GameObject vehiculo;
    private Vector3 desplazamiento = new Vector3(-4, 2, 0);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = vehiculo.transform.position + desplazamiento;

    }
}