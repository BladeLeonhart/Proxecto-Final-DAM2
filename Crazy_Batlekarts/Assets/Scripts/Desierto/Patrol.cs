using UnityEngine;

public class Patrol : MonoBehaviour
{
    public Transform[] patrol;
    private int Currentpoint;
    public float moveSpeed;

    void Start()
    {
        transform.position = patrol[0].position;
        Currentpoint = 0;
    }
    void Update()
    {
        if (Vector3.Distance(transform.position, patrol[Currentpoint].position) < 0.5f)
        {
            Currentpoint++;
        }

        if (Currentpoint >= patrol.Length)
        {
            Currentpoint = 0;
        }

        transform.position = Vector3.MoveTowards(transform.position, patrol[Currentpoint].position, moveSpeed * Time.deltaTime);
    }
}
