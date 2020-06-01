using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraGuia : MonoBehaviour
{
    public Transform cameraTarget;
    public float sSpeed = 10.0f;
    public Vector3 dist = new Vector3(-4, 2, 0);
    public Transform lookTarget;
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
        Vector3 dPos = cameraTarget.position + dist;
        Vector3 sPos = Vector3.Lerp(transform.position, dPos, sSpeed * Time.deltaTime);
        transform.position = sPos;
        transform.LookAt(lookTarget.position);
    }
}