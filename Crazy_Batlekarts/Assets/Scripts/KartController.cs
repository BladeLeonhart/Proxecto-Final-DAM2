﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KartController : MonoBehaviour
{



    private float velocidad = 20;
    private float velocidadGiro = 50;
    private float entradaHorizontal;
    private float entradaVertical;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        entradaHorizontal = Input.GetAxis("Horizontal");
        entradaVertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.back * Time.deltaTime * velocidad * entradaVertical);
        transform.Rotate(Vector3.up * Time.deltaTime * velocidadGiro * entradaHorizontal);

    }






}
