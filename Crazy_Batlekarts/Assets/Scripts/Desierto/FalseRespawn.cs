using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FalseRespawn : MonoBehaviour
{
    // Start is called before the first frame    public GameObject effect;

    private float duration = 3f;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coche"))
        {
            StartCoroutine(PickUp());
        }
    }

    IEnumerator PickUp()
    {
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;

        if (tag=="Moneda") 
        {
            gameObject.SetActive(false);
        }


       // Instantiate(effect, transform.position, transform.rotation);

        yield return new WaitForSeconds(duration);

        GetComponent<MeshRenderer>().enabled = true;
        GetComponent<Collider>().enabled = true;

        if (tag == "Moneda")
        {
            gameObject.SetActive(true);
        }


    }
}
