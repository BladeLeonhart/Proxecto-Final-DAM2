using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject effect;

    private float duration = 5f;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coche"))
        {
            StartCoroutine(PickUp());
        }
    }

    IEnumerator PickUp()
    {
        gameObject.active = false;


        // Instantiate(effect, transform.position, transform.rotation);

        yield return new WaitForSeconds(duration);

        gameObject.active = true;

    }
}
